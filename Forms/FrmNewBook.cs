using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmNewBook : Form
    {
        public FrmNewBook()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewBook newBook = new FrmNewBook();
            //newBook.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Books books = new Books();

            books.Titel = txtBookName.Text;
            books.Description = txtDescription.Text;
            books.Summary = rtxtSummary.Text;
            books.ISBN = txtISBN.Text;
            books.PublicationYear = txtPublicationYear.Text;
            books.Edition = txtEdition.Text;
            books.Language = txtLanguage.Text;
            books.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
            books.AuthorId = byte.Parse(lueAuthor.EditValue.ToString());
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

        private void NewBook_Load(object sender, EventArgs e)
        {
            ToBookList();
            lueAuthor.Properties.DataSource = db.Authors.ToList();
            luePublisher.Properties.DataSource = db.Publishers.ToList();
            lueType.Properties.DataSource = db.TypesOfBooks.ToList();
            lueAuthor.Properties.DataSource = db.BooksByCategories.ToList();
            lueSection.Properties.DataSource = db.Section.ToList();
        }

        void ToBookList()
        {
            var values = from books in db.Books
                select new
                {
                    books.Id,
                    books.Titel,
                    books.Description,
                    books.Summary,
                    books.ISBN,
                    books.PublicationYear,
                    books.Edition,
                    books.Language,
                    books.PrintLenght,
                    books.Authors.FullName,
                    books.Publishers.PublisherName,
                    books.TypesOfBooks.BookType,
                    books.BooksByCategories.Category,
                    books.Section.SectionName,
                    books.IsActive,
                    books.Note
                };
        }
    }
}
