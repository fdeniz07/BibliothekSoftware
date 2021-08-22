
namespace Bibliothek.Forms
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.rtxtSummary = new System.Windows.Forms.RichTextBox();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.lueAuthor = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueBookCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lueType = new DevExpress.XtraEditors.LookUpEdit();
            this.luePublisher = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtBookName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBookCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1184, 845);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1,
            this.gridView2,
            this.winExplorerView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.BestFitMaxRowCount = 3;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.Name = "winExplorerView1";
            // 
            // rtxtSummary
            // 
            this.rtxtSummary.Location = new System.Drawing.Point(1093, 740);
            this.rtxtSummary.Name = "rtxtSummary";
            this.rtxtSummary.Size = new System.Drawing.Size(227, 72);
            this.rtxtSummary.TabIndex = 37;
            this.rtxtSummary.Text = "Zusammenfassung";
            // 
            // btnList
            // 
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.Location = new System.Drawing.Point(142, 571);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(228, 37);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "AUFLISTEN";
            // 
            // lueAuthor
            // 
            this.lueAuthor.Location = new System.Drawing.Point(143, 209);
            this.lueAuthor.Name = "lueAuthor";
            this.lueAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAuthor.Properties.DisplayMember = "VollName";
            this.lueAuthor.Properties.ValueMember = "Id";
            this.lueAuthor.Size = new System.Drawing.Size(227, 20);
            this.lueAuthor.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(142, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 37);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "LÖSCHEN";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(142, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 37);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "AKTUALISIEREN";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(143, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "HINZUFÜGEN";
            // 
            // lueBookCategory
            // 
            this.lueBookCategory.Location = new System.Drawing.Point(142, 287);
            this.lueBookCategory.Name = "lueBookCategory";
            this.lueBookCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBookCategory.Properties.DisplayMember = "Category";
            this.lueBookCategory.Properties.ValueMember = "Id";
            this.lueBookCategory.Size = new System.Drawing.Size(227, 20);
            this.lueBookCategory.TabIndex = 16;
            // 
            // lueType
            // 
            this.lueType.Location = new System.Drawing.Point(142, 261);
            this.lueType.Name = "lueType";
            this.lueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueType.Properties.DisplayMember = "TypesOfBook";
            this.lueType.Properties.ValueMember = "Id";
            this.lueType.Size = new System.Drawing.Size(227, 20);
            this.lueType.TabIndex = 16;
            // 
            // luePublisher
            // 
            this.luePublisher.Location = new System.Drawing.Point(142, 235);
            this.luePublisher.Name = "luePublisher";
            this.luePublisher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePublisher.Properties.DisplayMember = "PublisherName";
            this.luePublisher.Properties.ValueMember = "Id";
            this.luePublisher.Size = new System.Drawing.Size(227, 20);
            this.luePublisher.TabIndex = 15;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(89, 212);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Classe :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(59, 360);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 13);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Erläuterung :";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(93, 294);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(34, 13);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Land : ";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(46, 264);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(81, 13);
            this.labelControl13.TabIndex = 13;
            this.labelControl13.Text = "Benutzer-Rolle :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioButton2);
            this.groupControl1.Controls.Add(this.radioButton1);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Controls.Add(this.lueAuthor);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.lueBookCategory);
            this.groupControl1.Controls.Add(this.lueType);
            this.groupControl1.Controls.Add(this.luePublisher);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.txtBookName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1193, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(388, 845);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "SCHÜLER/IN";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(87, 238);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(40, 13);
            this.labelControl12.TabIndex = 13;
            this.labelControl12.Text = "Schule :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Letzes Schuljahr :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(143, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(227, 20);
            this.txtId.TabIndex = 4;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(111, 60);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(16, 13);
            this.labelControl16.TabIndex = 3;
            this.labelControl16.Text = "Id :";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(143, 83);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(227, 20);
            this.txtBookName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Vorname :";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(67, 108);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(60, 13);
            this.labelControl17.TabIndex = 3;
            this.labelControl17.Text = "Nachname :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(143, 105);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(227, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(72, 134);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(55, 13);
            this.labelControl18.TabIndex = 38;
            this.labelControl18.Text = "Geschlect :";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(51, 186);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(76, 13);
            this.labelControl19.TabIndex = 5;
            this.labelControl19.Text = "Beschreibung :";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(143, 183);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(227, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(143, 131);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "VollName";
            this.lookUpEdit1.Properties.ValueMember = "Id";
            this.lookUpEdit1.Size = new System.Drawing.Size(227, 20);
            this.lookUpEdit1.TabIndex = 39;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(142, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 72);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "Zusammenfassung";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 323);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Status : ";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(142, 313);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(227, 38);
            this.radioGroup1.TabIndex = 42;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(173, 323);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aktiv";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(263, 323);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Passiv";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.rtxtSummary);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBookCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private System.Windows.Forms.RichTextBox rtxtSummary;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.LookUpEdit lueAuthor;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit lueBookCategory;
        private DevExpress.XtraEditors.LookUpEdit lueType;
        private DevExpress.XtraEditors.LookUpEdit luePublisher;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtBookName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}