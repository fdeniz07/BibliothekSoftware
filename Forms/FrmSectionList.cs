using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmSectionList : Form
    {
        public FrmSectionList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmSectionList_Load(object sender, EventArgs e)
        {
            SectionList();
        }

        private void SectionList()
        {
            var values = from section in db.Section
                select new
                {
                    section.Id,
                    Abteilung = section.SectionName,
                    Beschreibung = section.Details,
                    Status = section.IsActive,
                    Erläuterung=section.Note
                };
            gridControl1.DataSource = values.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int counter = 0;

            var query = (from x in db.Section select x.SectionName).Distinct();

            foreach (var data in query)
            {
                if (data.Equals(txtSectionName.Text))
                    counter++;
            }

            if (counter != 0)
                MessageBox.Show("Diese Abteilung ist existiert", "Warnung", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                Section section = new Section();
                section.SectionName = txtSectionName.Text;
                section.Details = txtDescription.Text;
                section.Note = txtNote.Text;
                section.IsActive = true;
                section.IsDeleted = false;

                db.Section.Add(section);
                db.SaveChanges();
                MessageBox.Show("Abteilung erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Section.Find(id);
            value.SectionName = txtSectionName.Text;
            value.Details = txtDescription.Text;
            value.Note = txtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Abteilung erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Section.Find(id);
            db.Section.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Abteilung erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SectionList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtSectionName.Text = gridView1.GetFocusedRowCellValue("Abteilung").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Erläuterung").ToString();
        }
    }
}
