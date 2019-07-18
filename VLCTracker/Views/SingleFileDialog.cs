using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCTracker.Views
{
    public partial class SingleFileDialog : Form
    {
        public Program.FileType fileType = Program.FileType.INVALID;

        public SingleFileDialog(string filepath)
        {
            InitializeComponent();
            lblFilename.Text = filepath;
        }

        private void btnSingleFile_Click(object sender, EventArgs e)
        {
            fileType = Program.FileType.SINGLE_FILE;
            this.Close();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            fileType = Program.FileType.PART_OF_SERIES;
            this.Close();
        }
    }
}
