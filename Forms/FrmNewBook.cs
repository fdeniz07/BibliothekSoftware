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

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Books books = new Books();

            if (txtBookName.Text.Length != null && txtBookName.Text.Length <= 50 && txtDescription.Text.Length <= 250 && lueAuthor.Text.Length != null && lueType.Text.Length != null && luePublisher.Text.Length != null && lueBookCategory.Text.Length != null && lueSection.Text.Length != null)
            {
                books.Title = txtBookName.Text;
                books.Description = txtDescription.Text;
                books.Summary = rtxtSummary.Text;
                books.ISBN = txtISBN.Text;
                books.PublicationYear = txtPublicationYear.Text;
                books.Edition = txtEdition.Text;
               // books.Language = txtLanguage.Text;
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
            else
            {
                MessageBox.Show("Buch konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            ToBookList();
            lueAuthor.Properties.DataSource = (from x in db.Authors
                                               select new
                                               {
                                                   x.Id,
                                                   Vollname = x.FullName
                                               }).ToList();//db.Authors.ToList();
            luePublisher.Properties.DataSource = (from x in db.Publishers
                                                  select new
                                                  {
                                                      x.Id,
                                                      Verlag = x.PublisherName
                                                  }).ToList();//db.Publishers.ToList();
            lueType.Properties.DataSource = (from x in db.TypesOfBooks
                                             select new
                                             {
                                                 x.Id,
                                                 Buchgenre = x.BookType
                                             }).ToList();//db.TypesOfBooks.ToList();
            lueBookCategory.Properties.DataSource = (from x in db.BooksByCategories
                                                     select new
                                                     {
                                                         x.Id,
                                                         Buchkategorie = x.Category
                                                     }).ToList();//db.TypesOfBooks.ToList();
            lueSection.Properties.DataSource = (from x in db.Section
                                                select new
                                                {
                                                    x.Id,
                                                    Abteilung = x.SectionName
                                                }).ToList();//db.Section.ToList();
        }

        private void ToBookList()
        {
            var values = from books in db.Books
                         select new
                         {
                             books.Id,
                             books.Title,
                             books.Description,
                             books.Summary,
                             books.ISBN,
                             books.PublicationYear,
                             books.Edition,
                             books.Languages.Language,
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