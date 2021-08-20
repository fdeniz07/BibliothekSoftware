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
            Forms.BookList bookList = new BookList();
            bookList.MdiParent = this;
            bookList.Show();
        }

        private void btnNewBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.NewBook newBook = new NewBook();
            newBook.Show();
        }
    }
}
