using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        string name;
        string path;
        List<Photo> photos;
        int currentPhotoIndex = -1;

        public string Name { get => name; }
        public string Path { get => path; }
        public int PhotoCount
        {
            get
            {
                if (photos == null)
                {
                    return 0;
                }
                else
                {
                    return photos.Count;
                }
            }
        }

        public PhotoAlbum(string name)
        {
            this.name = name;
            photos = new List<Photo>();
        }

        public PhotoAlbum()
        {
            photos = new List<Photo>();
        }

        internal bool Save(SaveFileDialog saveFileDialog)
        {
            if (path == null)
            {
                saveFileDialog.Filter = "Album (*.alb)|*.alb";
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                }
                else
                {
                    return false;
                }
            }

            // write the file
            using (StreamWriter writer = new StreamWriter(path))
            {
                //album Name
                writer.WriteLine(Name);

                //photo info to file
                foreach (Photo photo in photos)
                {
                    writer.WriteLine($"{photo.Path}|{photo.Description}");
                }

                MessageBox.Show($"Album {name} saved!", "Saved");
            }
            return true;

        }

        internal bool AddPhotos(OpenFileDialog openFileDialog)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files (*.jpeg;*.jpg)|*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in openFileDialog.FileNames)
                {
                    this.photos.Add(new Photo(path));
                }
                return true;
            }
            return false;
        }

        internal Photo GetNextImage()
        {
            if (photos.Count > 0)
            {
                currentPhotoIndex++;
                if (currentPhotoIndex >= photos.Count)
                {
                    currentPhotoIndex = 0;
                }
                return photos.ElementAt(currentPhotoIndex);
            }
            else
            {
                return null;
            }

        }

        internal Photo GetPreviousImage()
        {
            if (photos.Count > 0)
            {
                currentPhotoIndex--;
                if (currentPhotoIndex < 0)
                {
                    currentPhotoIndex = photos.Count - 1;
                }
                return photos.ElementAt(currentPhotoIndex);
            }
            else
            {
                return null;
            }

        }

        internal Photo GetCurrentPhoto()
        {
            return photos.ElementAt(currentPhotoIndex);
        }

        internal bool OpenAlbum(OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Album (*.alb)|*.alb";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                List<string> badPhotoPaths = new List<string>();

                string[] photosData = File.ReadAllLines(openFileDialog.FileName);
                name = photosData[0];
                for (int i = 1; i < photosData.Length; i++)
                {
                    string[] photoDetails = photosData[i].Split('|');
                    Photo photo = new Photo(photoDetails[0]);
                    photo.Description = photoDetails[1];

                    if (VerifyPhotoExists(photo))
                    {
                        photos.Add(photo);
                    }
                    else
                    {
                        badPhotoPaths.Add(photo.Path);
                    }
                }
               
                if (photos.Count > 0)
                {
                    return true;
                }
                else
                {
                    StringBuilder message = new StringBuilder();
                    message.AppendLine("Can't open album - photos invalid!");
                    foreach( string path in badPhotoPaths)
                    {
                        message.AppendLine(path);
                    }
                    MessageBox.Show(message.ToString());
                    return false;
                }                
                
            }
            else
            {
                return false;
            }
        }

        private bool VerifyPhotoExists(Photo photo)
        {
            return File.Exists(photo.Path);
        }
    }
}
