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
            BorrowingList();
        }

        private void BorrowingList()
        {
            //var values = from x in db.BorrowingBooks
            //    select new
            //    {
            //        x.Id,
            //        BuchTitel = x.Books.Title,
            //        Schüler = x.Students.FirstName + x.Students.LastName
            //    };
            //gridControl1.DataSource = values.ToList();

            var values = from x in db.BorrowingBookActivities
                select new
                {
                    x.Id,
                    BuchTitel = x.BorrowingBooks.Books.Title,
                    Schüler = x.BorrowingBooks.Students.FirstName + " " + x.BorrowingBooks.Students.LastName,
                    Statusart = x.BookTransactionType.Type,
                    Personal = x.Staves.FirstName + " " + x.Staves.LastName,
                    DatumDerAusleihe = x.DateOfBorrowing,
                    DatumDerAbgabe = x.ReturnDate,
                    Zeitraum = x.Period,
                    Überschreitung = x.DelayTime,
                    IstGelesen = x.IsRead/*,*/
                    //Strafe = x.Penalties.Pennt
                };
            gridControl1.DataSource = values.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();

        }
    }
}
