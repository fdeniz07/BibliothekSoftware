using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmNote_Load(object sender, EventArgs e)
        {
            NoteList1();
            NoteList2();
            //gridControl1.DataSource = db.Notes.Where(x => x.IsActive == false).ToList();
            //gridControl2.DataSource = db.Notes.Where(y => y.IsActive == true).ToList();
        }

        private void NoteList1()
        {
            var values = from notes in db.Notes.Where(x => x.IsActive == false)
                         select new
                {
                    notes.Id,
                    Titel = notes.Heading,
                    Inhalt = notes.ContentValue,
                    Ungelesen = notes.IsActive
                };
            gridControl1.DataSource = values.ToList();
        }

        private void NoteList2()
        {
            var values2 = from notes in db.Notes.Where(y => y.IsActive == true)
                select new
                {
                    notes.Id,
                    Titel = notes.Heading,
                    Inhalt = notes.ContentValue,
                    Ungelesen = notes.IsActive
                };
            gridControl2.DataSource = values2.ToList();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Heading = txtTitle.Text;
            notes.ContentValue = rtxtContent.Text;
            notes.IsActive = false;
            db.Notes.Add(notes);
            db.SaveChanges();
            MessageBox.Show("Notizen erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int id = int.Parse(txtId.Text);
                var value = db.Notes.Find(id);

                if (txtTitle.Text.Length != null && txtTitle.Text.Length <= 50)
                {
                    value.Heading = txtTitle.Text;
                    value.ContentValue = rtxtContent.Text;
                    value.IsActive = true;

                    db.SaveChanges();
                    MessageBox.Show("Notizen erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Notizen konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                NoteList1();
                NoteList2();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtTitle.Text = gridView1.GetFocusedRowCellValue("Titel").ToString();
            rtxtContent.Text = gridView1.GetFocusedRowCellValue("Inhalt").ToString();
        }
    }
}
