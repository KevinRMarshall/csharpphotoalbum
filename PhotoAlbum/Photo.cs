using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    class Photo
    {
        private string path;
        public string Path
        {
            get => path;            
        }

        private string description;
        public string Description { get => description; set => description = value; }

        public Photo( string path)
        {
            this.path = path;
        }

        internal string GetFileInfo()
        {
            DateTime creationDate = File.GetCreationTime(path);
            return ($"File Created: {creationDate.ToShortDateString()} - {creationDate.ToShortTimeString()}");            
        }
    }
}
