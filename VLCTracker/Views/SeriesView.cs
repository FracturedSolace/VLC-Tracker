using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VLCTracker.Classes;

namespace VLCTracker.Views
{
    public partial class SeriesView : Form
    {
        bool updating = false;
        public SeriesView()
        {
            InitializeComponent();
            updateSeriesInfo();
        }

        private void cmbSelectedSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating)
                return;
            updateSeriesInfo();
        }

        /// <summary>
        /// Refreshes displayed info about the currently selected series
        /// </summary>
        private void updateSeriesInfo()
        {
            //Internal variable to keep us from triggering a loop while we change field values
            updating = true;

            int prevIndex = 0;
            if (cmbSelectedSeries.Items.Count > 1)
                prevIndex = cmbSelectedSeries.SelectedIndex;

            cmbSelectedSeries.Items.Clear();
            List<Series> ListOfSeries = Program.LoadSeries();

            cmbSelectedSeries.Items.Add("(None)");
            foreach (Series item in ListOfSeries)
                cmbSelectedSeries.Items.Add(item);

            cmbSelectedSeries.SelectedIndex = prevIndex;

            cmbWatched.Items.Clear();
            cmbRemaining.Items.Clear();
            txtDirectory.Text = "";

            updating = false;

            if (cmbSelectedSeries.SelectedIndex == 0)//Default value for "(none)"
                return;

            Series currentSeries = cmbSelectedSeries.SelectedItem as Series;

            txtDirectory.Text = currentSeries.directory;

            foreach (string file in currentSeries.watched)
                cmbWatched.Items.Add(Path.GetFileName(file));
            foreach (string file in Directory.GetFiles(currentSeries.directory))
            {
                if (!currentSeries.watched.Contains(file))
                    cmbRemaining.Items.Add(Path.GetFileName(file));
            }
        }

        private void txtDirectory_MouseDown(object sender, MouseEventArgs e)
        {
            Process.Start("explorer.exe", txtDirectory.Text);
        }

        private void cmbDoubleClick(object sender, EventArgs e)
        {
            ListBox listbox = sender as ListBox;
            string filename = listbox.SelectedItem as string;
            Program.LoadFile(txtDirectory.Text + @"\" + filename);
            updateSeriesInfo();
        }

        private void cmbWatched_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                Series selectedSeries = cmbSelectedSeries.SelectedItem as Series;
                string episodeToRemove = selectedSeries.directory + @"\" + cmbWatched.SelectedItem as string;

                foreach (Series series in Program.ListOfSeries)
                {
                    if (series.directory == selectedSeries.directory)
                    {
                        int removeAt = -1;
                        for(int i=0; i < series.watched.Count; i++)
                        {
                            if (series.watched[i] == episodeToRemove)
                            {
                                removeAt = i;
                            }
                        }
                        if (removeAt == -1)
                            return;

                        series.watched.RemoveAt(removeAt);
                        Program.SaveSeries(Program.ListOfSeries);

                        updateSeriesInfo();
                    }
                }
            }
        }
    }
}
