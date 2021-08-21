using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewCategory newCategory = new FrmNewCategory();
        }
    }
}
