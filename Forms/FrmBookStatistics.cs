using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmBookStatistics : Form
    {
        public FrmBookStatistics()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmBookStatistics_Load(object sender, EventArgs e)
        {
            /*
             * 1- Toplam kitap sayisi - Gesamtzahl der Bücher - Total number of books
             * 2- Toplam Yazar Sayisi - Gesamtzahl der Autoren - Total number of authors
             * 3- Toplam basinevi sayisi - Gesamtzahl der Verlage - Total number of publishers
             * 4- Kitap türlerinin sayisi (Drama,Roman) - Gesamtzahlen der Buchgenres - Total numbers of book genres
             * 5- Toplam Bölüm sayisi (Bücherei,Lehrkraft) - Gesamtzahlen der Abteilung - Section totals
             *
             * 6- Toplam Kitap Kategorisi sayisi (Sek1,Sek2) - Gesamtzahlen der Kategorien - Total numbers of categories
             * 7- Farkli kitap sayisi - Gesamtzahlen verschiedener Bücher - Total numbers of different books
             * 8- Kitap dili sayisi - Gesamtzahl der Sprachen - Total number of languages
             * 9- En cok sayfaya sahip kitap - Das Buch mit den meisten Seiten - The book with the most pages
             * 10- En cok kitabin oldugu tür adi - Das Genre mit den meisten Büchern - Number of books with the most book genres
             *
             * 11- En az  kitabin oldugu tür adi - Das Genre mit den wenigsten Büchern - Number of books with the least book genres
             * 12- En cok kitaba sahip yazar - Autor mit den meisten Büchern - Author with most books
             * 13- En cok kitaba sahip yayinevi - Verlag mit den meisten Büchern - Publisher with most books
             * 14- En fazla kitabin oldugu bölüm adi - Die Abteilung mit den meisten Büchern - The section with the most books
             * 15- En fazla kitabin oldugu yayin yili - Maximale Anzahl an Erscheinungsjahren - Publication year with the most books
             *
             * 16- Özeti olan kitap sayisi - Anzahl Bücher mit Zusammenfassung - Number of books Summary
             * 17- Aktif olan kitap sayisi - Anzahl der aktiven Bücher - Number of active books
             * 18- 
             */

            lblTotalBook.Text = db.Books.Count().ToString(); //1
            lblTotalAuthor.Text = db.Authors.Count().ToString(); //2
            lblTotalPublisher.Text = db.Publishers.Count().ToString(); //3
            lblTotalBookType.Text = db.TypesOfBooks.Count().ToString(); //4
            lblSectionTotals.Text = db.Section.Count().ToString(); //5
            lblTotalCategory.Text = db.BooksByCategories.Count().ToString(); //6
            lblTotalDifferntBook.Text = (from x in db.Books select x.Titel).Distinct().Count().ToString(); //7
            lblTotalNumberOfLanguages.Text = (from x in db.Books select x.Language).Distinct().Count().ToString(); //8
            lblMostPages.Text = (from x in db.Books orderby x.PrintLenght descending select x.Titel).FirstOrDefault().ToString(); //9-1
            lblPageCount.Text = (from x in db.Books orderby x.PrintLenght descending select x.PrintLenght).FirstOrDefault().ToString(); //9-2
            


            //lblMostBookGenres.Text = db.Books.OrderByDescending(x => x.TypeId).GroupBy(y => y.TypesOfBooks.BookType).Select(z =>
            //    new
            //    {
            //        Bookgenre = z.Key,
            //        //Summe = z.Count()
            //    }).FirstOrDefault().ToString();

            //lblMostBookGenres.Text =
            //    (from x in db.Books group x.Titel by x.TypeId).Count().ToString();
            //lblLeastBookGenres.Text=


            lblNumberOfBooksSummary.Text = db.Books.Count(x => x.Summary != "").ToString(); //16

            //lblMaximumNumberOfYearsOfPublication.Text = 

            //lblDepartmenrWithMostOfTheBooks.Text = db.Books.Count()

            // lblCategoryWithTheMostBooks.Text =(from x in db.Books orderby x.BookCategoryId descending select x.Titel).FirstOrDefault();


            //var values = db.Books.OrderBy(x => x.TypeId).GroupBy(y => y.TypesOfBooks.BookType).Select(z => new
            //{
            //    BookType = z.Key,
            //    Summe = z.Count()
            //});

        }
    }
}
