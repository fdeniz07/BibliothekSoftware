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
    public partial class FrmBookCategory : Form
    {
        public FrmBookCategory()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void BookCategory_Load(object sender, EventArgs e)
        {
            ToCategoryList();
        }

        void ToCategoryList()
        {
            var values = from BookCategory in db.BooksByCategories
                         select new
                         {
                             BookCategory.Id,
                             BookCategory.Category,
                             BookCategory.Description,
                             BookCategory.IsActive,
                             BookCategory.Note
                         };
            gridControl1.DataSource = values.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBookCategory.Text = gridView1.GetFocusedRowCellValue("Category").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Note").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Kaydederken ayni kategori adindan olup olmadigini denetliyoruz
            
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.BooksByCategories.Find(id);
            value.Category = txtBookCategory.Text;
            value.Description = txtDescription.Text;
            value.Note = txtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Buchcategorie erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.BooksByCategories.Find(id);
            db.BooksByCategories.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Buchcategorie erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ToCategoryList();
        }
    }
}
