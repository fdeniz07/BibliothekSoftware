using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void BookList_Load(object sender, EventArgs e)
        {
            //Listeleme
            //var values = db.Books.ToList();
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
                             Buchtitel = books.Title,
                             Beschreibung = books.Description,
                             Zusammenfassung = books.Summary,
                             books.ISBN,
                             Erscheinungsjahr = books.PublicationYear,
                             Auflage = books.Edition,
                             Sprache = books.Language,
                             Drucklänge = books.PrintLenght,
                             Autor = books.Authors.FullName,
                             Verlag = books.Publishers.PublisherName,
                             Buchgenre = books.TypesOfBooks.BookType,
                             Buchkategorie = books.BooksByCategories.Category,
                             Abteilung = books.Section.SectionName,
                             QRCode = books.BarCode,
                             Status = books.IsActive,
                             Erläuterung = books.Note
                         };
            gridControl1.DataSource = values.ToList();
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
                books.Language = txtLanguage.Text;
                books.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
                books.AuthorId = byte.Parse(lueAuthor.EditValue.ToString());
                books.PublisherId = byte.Parse(luePublisher.EditValue.ToString());
                books.TypeId = byte.Parse(lueType.EditValue.ToString());
                books.BookCategoryId = byte.Parse(lueBookCategory.EditValue.ToString());
                books.SectionId = byte.Parse(lueSection.EditValue.ToString());
                books.QRCode = txtQRCode.Text;
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

        private void btnList_Click(object sender, EventArgs e)
        {
            //var values = db.Books.ToList();
            //gridControl1.DataSource = values;
            ToBookList();
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
            value.Title = txtBookName.Text;
            value.Description = txtDescription.Text;
            value.Summary = rtxtSummary.Text;
            value.ISBN = txtISBN.Text;
            value.PublicationYear = txtPublicationYear.Text;
            value.Edition = txtEdition.Text;
            value.Language = txtLanguage.Text;
            value.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
            value.QRCode = txtQRCode.Text;
            value.Note = txtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Buch erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBookName.Text = gridView1.GetFocusedRowCellValue("Buchtitel").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            rtxtSummary.Text = gridView1.GetFocusedRowCellValue("Zusammenfassung").ToString();
            txtISBN.Text = gridView1.GetFocusedRowCellValue("ISBN").ToString();
            txtPublicationYear.Text = gridView1.GetFocusedRowCellValue("Erscheinungsjahr").ToString();
            txtEdition.Text = gridView1.GetFocusedRowCellValue("Auflage").ToString();
            txtLanguage.Text = gridView1.GetFocusedRowCellValue("Sprache").ToString();
            txtPrintLenght.Text = gridView1.GetFocusedRowCellValue("Drucklänge").ToString();
            txtQRCode.Text = gridView1.GetFocusedRowCellValue("QRCode").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Erläuterung").ToString();

            //string selectSql = @"SELECT Id,FullName FROM [Authors]";
            //DataTable dtDetail = db.getDataTable(selectSql, db);
            //lueAuthor.Properties.DataSource = db.Authors;
            //lueAuthor.Properties.DisplayMember = "FullName";
            //lueType.Text = gridView1.GetFocusedRowCellValue("Autor").ToString();
            //lueAuthor.Properties.NullText = "Lütfen seçiniz.";
            //lueAuthor.Properties.ValueMember = "Id";
        }
    }
}