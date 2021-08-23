
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
            this.lueClass = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.lueUserRole = new DevExpress.XtraEditors.LookUpEdit();
            this.lueSchool = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbPassive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.lueGender = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastSchoolYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUserRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSchool.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastSchoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
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
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(172)))), ((int)(((byte)(13)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(179)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.BestFitMaxRowCount = 3;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            // lueClass
            // 
            this.lueClass.Location = new System.Drawing.Point(143, 209);
            this.lueClass.Name = "lueClass";
            this.lueClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueClass.Properties.DisplayMember = "VollName";
            this.lueClass.Properties.ValueMember = "Id";
            this.lueClass.Size = new System.Drawing.Size(227, 20);
            this.lueClass.TabIndex = 20;
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
            // lueCountry
            // 
            this.lueCountry.Location = new System.Drawing.Point(142, 287);
            this.lueCountry.Name = "lueCountry";
            this.lueCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCountry.Properties.DisplayMember = "Category";
            this.lueCountry.Properties.ValueMember = "Id";
            this.lueCountry.Size = new System.Drawing.Size(227, 20);
            this.lueCountry.TabIndex = 16;
            // 
            // lueUserRole
            // 
            this.lueUserRole.Location = new System.Drawing.Point(142, 261);
            this.lueUserRole.Name = "lueUserRole";
            this.lueUserRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUserRole.Properties.DisplayMember = "TypesOfBook";
            this.lueUserRole.Properties.ValueMember = "Id";
            this.lueUserRole.Size = new System.Drawing.Size(227, 20);
            this.lueUserRole.TabIndex = 16;
            // 
            // lueSchool
            // 
            this.lueSchool.Location = new System.Drawing.Point(142, 235);
            this.lueSchool.Name = "lueSchool";
            this.lueSchool.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSchool.Properties.DisplayMember = "PublisherName";
            this.lueSchool.Properties.ValueMember = "Id";
            this.lueSchool.Size = new System.Drawing.Size(227, 20);
            this.lueSchool.TabIndex = 15;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(89, 212);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(37, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Klasse :";
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
            this.groupControl1.Controls.Add(this.rbPassive);
            this.groupControl1.Controls.Add(this.rbActive);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.rtxtNote);
            this.groupControl1.Controls.Add(this.lueGender);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Controls.Add(this.lueClass);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.lueCountry);
            this.groupControl1.Controls.Add(this.lueUserRole);
            this.groupControl1.Controls.Add(this.lueSchool);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.txtLastSchoolYear);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtLastName);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.txtFirstName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1193, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(388, 845);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "SCHÜLER/IN";
            // 
            // rbPassive
            // 
            this.rbPassive.AutoSize = true;
            this.rbPassive.Location = new System.Drawing.Point(263, 323);
            this.rbPassive.Name = "rbPassive";
            this.rbPassive.Size = new System.Drawing.Size(55, 17);
            this.rbPassive.TabIndex = 43;
            this.rbPassive.TabStop = true;
            this.rbPassive.Text = "Passiv";
            this.rbPassive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(173, 323);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(50, 17);
            this.rbActive.TabIndex = 43;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktiv";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(142, 313);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(227, 38);
            this.radioGroup1.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 323);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Status : ";
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(142, 357);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(227, 72);
            this.rtxtNote.TabIndex = 40;
            this.rtxtNote.Text = "Zusammenfassung";
            // 
            // lueGender
            // 
            this.lueGender.Location = new System.Drawing.Point(143, 131);
            this.lueGender.Name = "lueGender";
            this.lueGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGender.Properties.DisplayMember = "VollName";
            this.lueGender.Properties.ValueMember = "Id";
            this.lueGender.Size = new System.Drawing.Size(227, 20);
            this.lueGender.TabIndex = 39;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(72, 134);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(55, 13);
            this.labelControl18.TabIndex = 38;
            this.labelControl18.Text = "Geschlect :";
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
            this.txtDescription.Location = new System.Drawing.Point(143, 183);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(51, 186);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(76, 13);
            this.labelControl19.TabIndex = 5;
            this.labelControl19.Text = "Beschreibung :";
            // 
            // txtLastSchoolYear
            // 
            this.txtLastSchoolYear.Location = new System.Drawing.Point(143, 157);
            this.txtLastSchoolYear.Name = "txtLastSchoolYear";
            this.txtLastSchoolYear.Size = new System.Drawing.Size(227, 20);
            this.txtLastSchoolYear.TabIndex = 6;
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
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(143, 105);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(227, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(67, 108);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(60, 13);
            this.labelControl17.TabIndex = 3;
            this.labelControl17.Text = "Nachname :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(143, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(227, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Vorname :";
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
            ((System.ComponentModel.ISupportInitialize)(this.lueClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUserRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSchool.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastSchoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit lueClass;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit lueCountry;
        private DevExpress.XtraEditors.LookUpEdit lueUserRole;
        private DevExpress.XtraEditors.LookUpEdit lueSchool;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtLastSchoolYear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueGender;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.RadioButton rbPassive;
        private System.Windows.Forms.RadioButton rbActive;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox rtxtNote;
    }
}