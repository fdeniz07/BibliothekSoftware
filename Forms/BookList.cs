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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void BookList_Load(object sender, EventArgs e)
        {
            //Listeleme
            var values = db.Books.ToList();
            gridControl1.DataSource = values;
            lueAuthor.Properties.DataSource = db.Authors.ToList();
            luePublisher.Properties.DataSource = db.Publishers.ToList();
            lueType.Properties.DataSource = db.TypesOfBooks.ToList();
            lueAuthor.Properties.DataSource = db.BooksByCategories.ToList();
            lueSection.Properties.DataSource = db.Section.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Titel = txtBookName.Text;
            books.Description = txtDescription.Text;
            books.Summary = txtSummary.Text;
            books.ISBN = txtISBN.Text;
            books.PublicationYear = txtPublicationYear.Text;
            books.Edition = txtEdition.Text;
            books.Language = txtLanguage.Text;
            books.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
            books.AuthorId =byte.Parse( lueAuthor.EditValue.ToString());
            books.PublisherId = byte.Parse(luePublisher.EditValue.ToString());
            books.TypeId = byte.Parse(lueType.EditValue.ToString());
            books.BookCategoryId = byte.Parse(lueBookCategory.EditValue.ToString());
            books.SectionId = byte.Parse(lueSection.EditValue.ToString());
            books.Note = txtNote.Text;
            books.IsActive = true;
            books.IsDeleted = false;

            db.Books.Add(books);
            db.SaveChanges();
            MessageBox.Show("Buch erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Books.ToList();
            gridControl1.DataSource = values;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBookName.Text = gridView1.GetFocusedRowCellValue("Titel").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Description").ToString();
            txtSummary.Text = gridView1.GetFocusedRowCellValue("Summary").ToString();
            txtISBN.Text = gridView1.GetFocusedRowCellValue("ISBN").ToString();
            txtPublicationYear.Text = gridView1.GetFocusedRowCellValue("PublicationYear").ToString();
            txtEdition.Text = gridView1.GetFocusedRowCellValue("Edition").ToString();
            txtLanguage.Text = gridView1.GetFocusedRowCellValue("Language").ToString();
            txtPrintLenght.Text = gridView1.GetFocusedRowCellValue("PrintLenght").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Note").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Books.Find(id);
            db.Books.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Buch erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Books.Find(id);
            value.Titel = txtBookName.Text;
            value.Description = txtDescription.Text;
            value.Summary = txtSummary.Text;
            value.ISBN = txtISBN.Text;
            value.PublicationYear = txtPublicationYear.Text;
            value.Edition = txtEdition.Text;
            value.Language = txtLanguage.Text;
            value.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
            value.Note = txtNote.Text;
            


            db.SaveChanges();
            MessageBox.Show("Buch erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
