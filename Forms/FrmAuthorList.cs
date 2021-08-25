using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmAuthorList : Form
    {
        public FrmAuthorList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmAuthorList_Load(object sender, EventArgs e)
        {
            AuthorList();
        }


        private void AuthorList()
        {
            var values = from authors in db.Authors
                         select new
                         {
                             authors.Id,
                             Vorname = authors.FirstName,
                             Nachname = authors.LastName,
                             Vollname = authors.FullName,
                             Beschreibung = authors.AuthorAbout,
                             Status = authors.IsActive,
                             Erläuterung=authors.Note
                         };
            gridControl1.DataSource = values.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();

            if (txtFirstName.Text.Length <=50 && txtLastName.Text.Length<=50  )
            {
                authors.FirstName = txtFirstName.Text;
                authors.LastName = txtLastName.Text;
                authors.FullName = txtFirstName.Text + txtLastName.Text;
                authors.AuthorAbout = txtDescription.Text;
                authors.IsActive = true;
                authors.IsDeleted = false;
                authors.Note = rtxtNote.Text;

                db.Authors.Add(authors);
                db.SaveChanges();
                MessageBox.Show("Author erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Author erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Authors.Find(id);
            value.FirstName = txtFirstName.Text;
            value.LastName = txtLastName.Text;
            value.FullName = txtFirstName.Text + txtLastName.Text;
            value.AuthorAbout = txtDescription.Text;
            value.Note = rtxtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Author erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Authors.Find(id);
            db.Authors.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Author erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AuthorList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtFirstName.Text = gridView1.GetFocusedRowCellValue("Vorname").ToString();
            txtLastName.Text = gridView1.GetFocusedRowCellValue("Nachname").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            rtxtNote.Text = gridView1.GetFocusedRowCellValue("Erläuterung").ToString();
        }
    }
}