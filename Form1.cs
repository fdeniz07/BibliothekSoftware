using Bibliothek.Forms;
using System.Windows.Forms;

namespace Bibliothek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookList bookList = new FrmBookList();
            bookList.MdiParent = this;
            bookList.Show();
        }

        private void btnNewBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewBook newBook = new FrmNewBook();
            newBook.Show();
        }

        private void btnCategoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookCategory bookCategory = new FrmBookCategory();
            bookCategory.MdiParent = this;
            bookCategory.Show();

        }

        private void btnNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewCategory newCategory = new FrmNewCategory();
            newCategory.Show();
        }

        private void btnBookStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookStatistics bookStatistics = new FrmBookStatistics();
            bookStatistics.MdiParent = this;
            bookStatistics.Show();
        }

        private void btnBookType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookType bookType = new FrmBookType();
            bookType.MdiParent = this;
            bookType.Show();
        }

        private void bntQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmQRCode qrCode = new FrmQRCode();
            //qrCode.MdiParent = this;
            qrCode.Show();
        }
    }
}
