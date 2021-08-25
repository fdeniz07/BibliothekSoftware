using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int counter = 0;

            var query = (from x in db.BooksByCategories select x.Category).Distinct();

            foreach (var data in query)
            {
                if (data.Equals(txtBookCategory.Text))
                    counter++;
            }

            if (counter != 0)
                MessageBox.Show("Diese Kategorie ist existiert", "Warnung", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                BooksByCategories booksByCategories = new BooksByCategories();

                if (txtBookCategory.Text.Length!=null && txtBookCategory.Text.Length<=50 && txtDescription.Text.Length<=250)
                {
                    booksByCategories.Category = txtBookCategory.Text;
                    booksByCategories.Description = txtDescription.Text;
                    booksByCategories.Note = txtNote.Text;
                    booksByCategories.IsActive = true;
                    booksByCategories.IsDeleted = false;

                    db.BooksByCategories.Add(booksByCategories);
                    db.SaveChanges();
                    MessageBox.Show("Buchcategorie erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Buchcategorie erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewCategory newCategory = new FrmNewCategory();
        }
    }
}