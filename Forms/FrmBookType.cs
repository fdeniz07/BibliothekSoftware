using DevExpress.Data.WcfLinq.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmBookType : Form
    {
        public FrmBookType()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmBookType_Load(object sender, EventArgs e)
        {
            var values = db.Books.OrderBy(x => x.TypeId).GroupBy(y => y.TypesOfBooks.BookType).Select(z => new
            {
                Buchgenre = z.Key,
                Summe = z.Count()
            }).ToList();
            gridControl1.DataSource = values;

            lblTotalBook.Text = db.Books.Count().ToString();
            lblTotalBookType.Text = db.TypesOfBooks.Count().ToString();
            lblTotalAuthor.Text = db.Authors.Count().ToString();
            lblTotalPublisher.Text = db.Publishers.Count().ToString();

            foreach (var item in values)
            {
                chartControl1.Series["Series 1"].Points.AddPoint(item.Buchgenre, item.Summe);
            }

            var values2 = db.Books.OrderBy(x => x.Languages.Language).GroupBy(y => y.Languages.Language).Select(z => new
            {
                Sprache = z.Key,
                Summe = z.Count()
            }).ToList();

            foreach (var item in values2)
            {
                chartControl2.Series["Series 1"].Points.AddPoint(item.Sprache, item.Summe);
            }
        }
    }
}