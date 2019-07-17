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

namespace VLCTracker
{
    class Program
    {
        const string VLCPath = @"D:\Programs\VLC\vlc.exe";
        const string LogPath = @"D:\Desktop\vlc-log.txt";

        static void Main(string[] args)
        {
            if(args.Count() < 1)
                return;

            string filepath = "";
            foreach(string arg in args)
            {
                filepath += arg + " ";
            }
            //Trim last trailing space
            filepath = filepath.Substring(0, filepath.Length - 1);

            if (!File.Exists(filepath))
            {
                Log("Attempted to load non-existant file: "+filepath);
                return;
            }

            RecordWatched(filepath);

            PassToVlc(filepath);
        }

        private static void PassToVlc(string filepath)
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
        static void Log(string text)
        {
            using (StreamWriter writeFile = new StreamWriter(LogPath, append: true))
            {
                writeFile.WriteLine(readableTimestamp() + text);
            }
        }
    }
}
