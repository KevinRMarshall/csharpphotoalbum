namespace PhotoAlbum
{
    partial class PhotoAlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbCanvasColour = new System.Windows.Forms.GroupBox();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.pnlPhotoNav = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFileCreatedDate = new System.Windows.Forms.Label();
            this.btnAddPhotos = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.btnOpenAlbum = new System.Windows.Forms.Button();
            this.btnNewAlbum = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.grbCanvasColour.SuspendLayout();
            this.pnlPhotoNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbCanvasColour);
            this.panel1.Controls.Add(this.pnlPhotoNav);
            this.panel1.Controls.Add(this.btnSaveAlbum);
            this.panel1.Controls.Add(this.btnOpenAlbum);
            this.panel1.Controls.Add(this.btnNewAlbum);
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 433);
            this.panel1.TabIndex = 0;
            // 
            // grbCanvasColour
            // 
            this.grbCanvasColour.Controls.Add(this.rdbGray);
            this.grbCanvasColour.Controls.Add(this.rdbWhite);
            this.grbCanvasColour.Controls.Add(this.rdbBlack);
            this.grbCanvasColour.Location = new System.Drawing.Point(535, 264);
            this.grbCanvasColour.Name = "grbCanvasColour";
            this.grbCanvasColour.Size = new System.Drawing.Size(275, 100);
            this.grbCanvasColour.TabIndex = 10;
            this.grbCanvasColour.TabStop = false;
            this.grbCanvasColour.Text = "Canvas Colour";
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(210, 43);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(47, 17);
            this.rdbGray.TabIndex = 2;
            this.rdbGray.TabStop = true;
            this.rdbGray.Text = "Grey";
            this.rdbGray.UseVisualStyleBackColor = true;
            this.rdbGray.CheckedChanged += new System.EventHandler(this.CanvasColour_CheckedChanged);
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(122, 43);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(53, 17);
            this.rdbWhite.TabIndex = 1;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.CanvasColour_CheckedChanged);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(35, 43);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.CanvasColour_CheckedChanged);
            // 
            // pnlPhotoNav
            // 
            this.pnlPhotoNav.Controls.Add(this.btnPrevious);
            this.pnlPhotoNav.Controls.Add(this.btnNext);
            this.pnlPhotoNav.Controls.Add(this.lblFileCreatedDate);
            this.pnlPhotoNav.Controls.Add(this.btnAddPhotos);
            this.pnlPhotoNav.Controls.Add(this.txtDescription);
            this.pnlPhotoNav.Controls.Add(this.lblDescription);
            this.pnlPhotoNav.Enabled = false;
            this.pnlPhotoNav.Location = new System.Drawing.Point(537, 13);
            this.pnlPhotoNav.Name = "pnlPhotoNav";
            this.pnlPhotoNav.Size = new System.Drawing.Size(273, 225);
            this.pnlPhotoNav.TabIndex = 9;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(94, 182);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(180, 182);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFileCreatedDate
            // 
            this.lblFileCreatedDate.AutoSize = true;
            this.lblFileCreatedDate.Location = new System.Drawing.Point(11, 152);
            this.lblFileCreatedDate.Name = "lblFileCreatedDate";
            this.lblFileCreatedDate.Size = new System.Drawing.Size(0, 13);
            this.lblFileCreatedDate.TabIndex = 5;
            // 
            // btnAddPhotos
            // 
            this.btnAddPhotos.Location = new System.Drawing.Point(8, 182);
            this.btnAddPhotos.Name = "btnAddPhotos";
            this.btnAddPhotos.Size = new System.Drawing.Size(85, 23);
            this.btnAddPhotos.TabIndex = 7;
            this.btnAddPhotos.Text = "Add Photos";
            this.btnAddPhotos.UseVisualStyleBackColor = true;
            this.btnAddPhotos.Click += new System.EventHandler(this.btnAddPhotos_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 26);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 120);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Enabled = false;
            this.btnSaveAlbum.Location = new System.Drawing.Point(717, 389);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(85, 23);
            this.btnSaveAlbum.TabIndex = 8;
            this.btnSaveAlbum.Text = "Save Album";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Location = new System.Drawing.Point(626, 389);
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(85, 23);
            this.btnOpenAlbum.TabIndex = 6;
            this.btnOpenAlbum.Text = "Open Album";
            this.btnOpenAlbum.UseVisualStyleBackColor = true;
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // btnNewAlbum
            // 
            this.btnNewAlbum.Location = new System.Drawing.Point(535, 389);
            this.btnNewAlbum.Name = "btnNewAlbum";
            this.btnNewAlbum.Size = new System.Drawing.Size(85, 23);
            this.btnNewAlbum.TabIndex = 5;
            this.btnNewAlbum.Text = "Create Album";
            this.btnNewAlbum.UseVisualStyleBackColor = true;
            this.btnNewAlbum.Click += new System.EventHandler(this.btnNewAlbum_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(12, 13);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(517, 399);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // PhotoAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 456);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PhotoAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhotoAlbumForm_FormClosing);
            this.Load += new System.EventHandler(this.PhotoAlbumForm_Load);
            this.panel1.ResumeLayout(false);
            this.grbCanvasColour.ResumeLayout(false);
            this.grbCanvasColour.PerformLayout();
            this.pnlPhotoNav.ResumeLayout(false);
            this.pnlPhotoNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnNewAlbum;
        private System.Windows.Forms.Button btnOpenAlbum;
        private System.Windows.Forms.Button btnAddPhotos;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblFileCreatedDate;
        private System.Windows.Forms.Panel pnlPhotoNav;
        private System.Windows.Forms.GroupBox grbCanvasColour;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
    }
}

