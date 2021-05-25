using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class CreateAlbumForm : Form
    {
        string albumName;
        public string AlbumName
        {
            get => albumName;
        }        

        public CreateAlbumForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            albumName = txtAlbumName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
