////////////////////////////////////////////////////////////////////
//A class which represents a series of shows stored in a directory//
////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLCTracker.Classes
{
    public class Series
    {
        public string directory;
        public string seriesname;
        public List<string> watched = new List<string>();

        internal Series()
        {

        }
        public Series(string directory, string seriesname)
        {
            this.directory = directory;
            this.seriesname = seriesname;
        }

        public override string ToString()
        {
            return this.seriesname;
        }
    }
}
