///////////////////////////////////////////////////////////////////////////////////////////////
//Simple windowless program to track files which it opens, then pass them to VLC media player//
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static RobLibrary.Debug;
using VLCTracker.Views;
using VLCTracker.Classes;
using System.Xml.Serialization;

namespace VLCTracker
{
    public class Program
    {
        const string VLCPath = @"D:\Programs\VLC\vlc.exe";
        const string LogPath = @"D:\Desktop\vlc-log.txt";
        const string DataDirectory = @"D:\Programs\VLC\VLC-Tracker-Data\";
        const string SeriesFileName = @"Series.xml";

        public enum FileType { SINGLE_FILE, PART_OF_SERIES, INVALID };

        public static List<Series> ListOfSeries;

        static void Main(string[] args)
        {
            if (!Directory.Exists(DataDirectory))
                Directory.CreateDirectory(DataDirectory);

            ListOfSeries = LoadSeries();

            if (args.Count() < 1)
            {
                var popup = new SeriesView();
                popup.ShowDialog();
                return;
            }
            string filepath = ConvertArgsToFilepath(args);

            LoadFile(filepath);
        }

        /// <summary>
        /// Loads the selected file through the program, including logging
        /// </summary>
        /// <param name="filepath"></param>
        public static void LoadFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                Log("Attempted to load non-existant file: " + filepath);
                return;
            }

            RecordWatched(filepath);

            FileType typeOfFile;
            bool seriesInitialized = false;
            string fileDirectory = Path.GetDirectoryName(filepath);

            //Check type of file, either by finding it in an existing series or querrying the user
            if (FilePartOfSeries(filepath))
            {
                typeOfFile = FileType.PART_OF_SERIES;
                seriesInitialized = true;
            }
            else
            {
                typeOfFile = AskFileType(filepath);
            }

            //Exit out if the user didn't select a valid option
            if (typeOfFile == FileType.INVALID)
                return;

            //Record this file in the series.xml log if it's part of a series
            if (typeOfFile == FileType.PART_OF_SERIES)
            {
                if (!seriesInitialized)
                    InitializeSeries(Path.GetDirectoryName(filepath));
                SetWatched(filepath);
            }

            PassToVlc(filepath);
        }

        /// <summary>
        /// Finds out which series a file belongs to and adds it to the "watched" attribute of that series
        /// </summary>
        /// <param name="filepath"></param>
        private static void SetWatched(string filepath)
        {
            foreach (Series item in ListOfSeries)
            {
                if (item.directory == Path.GetDirectoryName(filepath))
                {
                    if (!item.watched.Contains(filepath))
                    {
                        item.watched.Add(filepath);
                    }
                }
            }
            SaveSeries(ListOfSeries);
        }

        /// <summary>
        /// Takes a filepath and checks if the file is a part of any indexed series
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private static bool FilePartOfSeries(string filepath)
        {
            string directory = Path.GetDirectoryName(filepath);

            foreach(Series series in ListOfSeries)
            {
                if (series.directory == directory)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Takes a list of arguments and puts them together as a single filepath
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static string ConvertArgsToFilepath(string[] args)
        {
            string filepath = "";
            foreach (string arg in args)
            {
                filepath += arg + " ";
            }
            //Trim last trailing space
            filepath = filepath.Substring(0, filepath.Length - 1);

            return filepath;
        }

        /// <summary>
        /// Queries the user to select whether a file should be treated individually or as a part of a series
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns>FileType.SINGLE_FILE or FileType.PART_OF_SERIES</returns>
        private static FileType AskFileType(string filepath)
        {
            var dialog = new SingleFileDialog(filepath);
            dialog.ShowDialog();

            return dialog.fileType;
        }

        /// <summary>
        /// Prompts the user to set up a new series in a specified directory
        /// </summary>
        /// <param name="directory"></param>
        private static void InitializeSeries(string directory)
        {
            var popup = new InitializeSeriesWindow(directory);
            popup.ShowDialog();

            Series newSeries = new Series(directory, popup.seriesname);

            AddSeriesToFile(newSeries);
        }

        /// <summary>
        /// Adds a new series to the series.xml file and then saves it
        /// </summary>
        /// <param name="series"></param>
        private static void AddSeriesToFile(Series series)
        {
            ListOfSeries.Add(series);
            SaveSeries(ListOfSeries);
        }

        /// <summary>
        /// Saves the series.dat file with the specified List of Series objects
        /// </summary>
        /// <param name="list"></param>
        public static void SaveSeries(List<Series> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Series>));
            using (TextWriter writer = new StreamWriter(DataDirectory + SeriesFileName))
            {
                serializer.Serialize(writer, list);
            }
        }

        /// <summary>
        /// Loads series.xml into a List of Series elements
        /// </summary>
        /// <returns></returns>
        public static List<Series> LoadSeries()
        {
            const string SeriesFileLocation = DataDirectory + SeriesFileName;
            if (!File.Exists(SeriesFileLocation))
                return new List<Series>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Series>));
            List<Series> list;

            using (Stream reader = new FileStream(SeriesFileLocation, FileMode.Open))
            {
                list = (List<Series>)serializer.Deserialize(reader);
            }

            return list;
        }

        /// <summary>
        /// Passes a file over to VLC media player
        /// </summary>
        /// <param name="filepath"></param>
        public static void PassToVlc(string filepath)
        {
            using (Process vlc = new Process())
            {
                vlc.StartInfo.UseShellExecute = false;
                vlc.StartInfo.FileName = VLCPath;
                vlc.StartInfo.CreateNoWindow = false;
                vlc.StartInfo.Arguments = String.Format(" \"{0}\" ", filepath);

                vlc.Start();
            }
        }

        /// <summary>
        /// Adds a simple text-based log entry that a single file was watched
        /// </summary>
        /// <param name="filename"></param>
        static void RecordWatched(string filename)
        {
            using (StreamWriter writeFile = new StreamWriter(LogPath, append: true))
            {
                writeFile.WriteLine(readableTimestamp());
                writeFile.WriteLine(Path.GetFileNameWithoutExtension(filename));
                writeFile.WriteLine(filename);
                writeFile.WriteLine("------------------------------------------------");
            }
        }

        /// <summary>
        /// Same as RecordWatched, but for any type of text (not just filenames)
        /// </summary>
        /// <param name="text"></param>
        static void Log(string text)
        {
            using (StreamWriter writeFile = new StreamWriter(LogPath, append: true))
            {
                writeFile.WriteLine(readableTimestamp() + text);
            }
        }
    }
}
