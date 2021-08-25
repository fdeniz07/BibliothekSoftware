
namespace Bibliothek.Forms
{
    partial class FrmNewPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewPublisher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit16 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit16 = new DevExpress.XtraEditors.PictureEdit();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureEdit15 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPublisherAbout = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPublisherName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublisherAbout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublisherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageSlider1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 324);
            this.panel1.TabIndex = 63;
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(320, 324);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // txtNote
            // 
            this.txtNote.EditValue = "Erläuterung";
            this.txtNote.Location = new System.Drawing.Point(417, 197);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtNote.Properties.Appearance.Options.UseBackColor = true;
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Properties.Appearance.Options.UseForeColor = true;
            this.txtNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtNote.Size = new System.Drawing.Size(252, 26);
            this.txtNote.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(535, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ABBRECHEN";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(379, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "HINZUFÜGEN";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textEdit16
            // 
            this.textEdit16.EditValue = "NEUER VERLAG";
            this.textEdit16.Location = new System.Drawing.Point(452, 23);
            this.textEdit16.Name = "textEdit16";
            this.textEdit16.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit16.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit16.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit16.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit16.Properties.Appearance.Options.UseFont = true;
            this.textEdit16.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit16.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit16.Size = new System.Drawing.Size(145, 26);
            this.textEdit16.TabIndex = 73;
            // 
            // pictureEdit16
            // 
            this.pictureEdit16.EditValue = ((object)(resources.GetObject("pictureEdit16.EditValue")));
            this.pictureEdit16.Location = new System.Drawing.Point(379, 12);
            this.pictureEdit16.Name = "pictureEdit16";
            this.pictureEdit16.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit16.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit16.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit16.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit16.Size = new System.Drawing.Size(67, 57);
            this.pictureEdit16.TabIndex = 72;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(417, 223);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(252, 3);
            this.panel15.TabIndex = 71;
            // 
            // pictureEdit15
            // 
            this.pictureEdit15.EditValue = ((object)(resources.GetObject("pictureEdit15.EditValue")));
            this.pictureEdit15.Location = new System.Drawing.Point(379, 199);
            this.pictureEdit15.Name = "pictureEdit15";
            this.pictureEdit15.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit15.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit15.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit15.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit15.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit15.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(417, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 3);
            this.panel2.TabIndex = 69;
            // 
            // txtPublisherAbout
            // 
            this.txtPublisherAbout.EditValue = "Verlag Details";
            this.txtPublisherAbout.Location = new System.Drawing.Point(417, 145);
            this.txtPublisherAbout.Name = "txtPublisherAbout";
            this.txtPublisherAbout.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPublisherAbout.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherAbout.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtPublisherAbout.Properties.Appearance.Options.UseBackColor = true;
            this.txtPublisherAbout.Properties.Appearance.Options.UseFont = true;
            this.txtPublisherAbout.Properties.Appearance.Options.UseForeColor = true;
            this.txtPublisherAbout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPublisherAbout.Size = new System.Drawing.Size(256, 26);
            this.txtPublisherAbout.TabIndex = 2;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(379, 147);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(417, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 3);
            this.panel3.TabIndex = 66;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.EditValue = "Verlag";
            this.txtPublisherName.Location = new System.Drawing.Point(417, 94);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPublisherName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtPublisherName.Properties.Appearance.Options.UseBackColor = true;
            this.txtPublisherName.Properties.Appearance.Options.UseFont = true;
            this.txtPublisherName.Properties.Appearance.Options.UseForeColor = true;
            this.txtPublisherName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPublisherName.Size = new System.Drawing.Size(252, 26);
            this.txtPublisherName.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(379, 96);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 64;
            // 
            // FrmNewPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(708, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textEdit16);
            this.Controls.Add(this.pictureEdit16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pictureEdit15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPublisherAbout);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNewPublisher";
            this.Text = "FrmNewPublisher";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublisherAbout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublisherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit16;
        private DevExpress.XtraEditors.PictureEdit pictureEdit16;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.PictureEdit pictureEdit15;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtPublisherAbout;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtPublisherName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}