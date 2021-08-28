using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmBorrowingBooksList : Form
    {
        public FrmBorrowingBooksList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmBorrowingBooksList_Load(object sender, EventArgs e)
        {

        }

        private void BorrowingList()
        {
            var values = from x in db.BorrowingBooks
                select new
                {
                    x.Id,
                    BuchTitel = x.Books.Title,
                    Schüler = x.Students.FirstName + x.Students.LastName
                };
            gridControl1.DataSource = values.ToList();
        }
    }
}
