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

namespace PhotoAlbum
{
    public partial class PhotoAlbumForm : Form
    {
        PhotoAlbum album;

        const string APP_TITLE = "Photo Album";
        
        
        public PhotoAlbumForm()
        {
            InitializeComponent();
        }

        private void btnNewAlbum_Click(object sender, EventArgs e)
        {
            if( album != null)
            {
                switch( MessageBox.Show("Would you like to save your current photo album?", 
                                        "Save Album", 
                                        MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        if( album.Save( saveFileDialog ))
                        {                            
                            break;
                        }
                        else
                        {                            
                            return;
                        }         
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        break;
                }                
            }

            CreateAlbumForm newAlbum = new CreateAlbumForm();
            if( newAlbum.ShowDialog(this) == DialogResult.OK)
            {
                album = new PhotoAlbum(newAlbum.AlbumName);
                pnlPhotoNav.Enabled = true;
                this.Text = $"{APP_TITLE} - {album.Name}";

                btnSaveAlbum.Enabled = true;
                SetPrevNextButtonState();
            }
            
        }

        private void SetPrevNextButtonState()
        {           
            bool enabled = true;
            if (album.PhotoCount == 0)
            {
                enabled = false;
            }

            btnPrevious.Enabled = enabled;
            btnNext.Enabled = enabled;
        }

        private void btnAddPhotos_Click(object sender, EventArgs e)
        {
            if( album.AddPhotos(openFileDialog) )
            {
                DisplayNextImage();
                SetPrevNextButtonState();
            }
            
        }

        private void DisplayNextImage()
        {
            Photo photo = album.GetNextImage();
            if( photo != null)
            {
                DisplayImage(photo);
                
            }
        }

        private void DisplayPreviousImage()
        {
            Photo photo = album.GetPreviousImage();
            if (photo != null)
            {
                DisplayImage(photo);                
            }
        }

        private void DisplayImage(Photo photo)
        {           
            if (photo == null)
                return;            

            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
           
            if (picPhoto.Image != null)
            {
                picPhoto.Image.Dispose();
                picPhoto.Image = null;
            }

            picPhoto.ImageLocation = photo.Path;
            txtDescription.Text = photo.Description;
            lblFileCreatedDate.Text = photo.GetFileInfo();
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (album != null)
            {

                Photo photo = album.GetCurrentPhoto();
                photo.Description = txtDescription.Text;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayNextImage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            DisplayPreviousImage();
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            if( album.Save(saveFileDialog))
            {
                this.Text = $"{APP_TITLE} - {album.Name} - {album.Path}";
            }
        }

        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            album = new PhotoAlbum();
            if( album.OpenAlbum(openFileDialog) == true)
            {
                pnlPhotoNav.Enabled = true;
                this.Text = $"{APP_TITLE} - {album.Name} - {album.Path}";
                DisplayImage(album.GetNextImage());

                btnSaveAlbum.Enabled = true;
            }
            else
            {              
                album = null;
            }
            
        }

        private void CanvasColour_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton colour = (RadioButton)sender;
            picPhoto.BackColor = (Color)colour.Tag;
        }

        private void PhotoAlbumForm_Load(object sender, EventArgs e)
        {           
            rdbGray.Tag = picPhoto.BackColor;
            rdbBlack.Tag = Color.Black;
            rdbWhite.Tag = Color.White;
        
            rdbBlack.Checked = true;
        }

        private void PhotoAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( album != null)
            {
                switch (MessageBox.Show("Do you want to save the album before closing?", "Closing", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        album.Save(saveFileDialog);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            
        }
    }
}
