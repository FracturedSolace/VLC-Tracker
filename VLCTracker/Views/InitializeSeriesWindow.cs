using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCTracker.Views
{
    public partial class InitializeSeriesWindow : Form
    {
        public string seriesname = "";

        public InitializeSeriesWindow(string directory)
        {
            InitializeComponent();
            txtDirectory.Text = Path.GetFileName(directory);
        }

        public string Pathdirectory { get; }

        private void btnDone_Click(object sender, EventArgs e)
        {
            seriesname = txtName.Text;
            this.Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDone_Click(null, null);
        }
    }
}
