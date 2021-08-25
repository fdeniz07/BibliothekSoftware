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
            qrCode.Show();
        }

        private void btnStudentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmStudent student = new FrmStudent();
            student.MdiParent = this;
            student.Show();
        }

        private void btnBookList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookList bookList = new FrmBookList();
            bookList.MdiParent = this;
            bookList.Show();
        }

        private void btnBookGenreList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmBookGenre bookGenre = new FrmBookGenre();
            bookGenre.MdiParent = this;
            bookGenre.Show();
        }

        private void btnBookGenreAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewBookGenre bookGenre = new FrmNewBookGenre();
            bookGenre.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        private void btnAuthorList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmAuthorList authorList = new FrmAuthorList();
            authorList.MdiParent = this;
            authorList.Show();
        }

        private void btnSectionList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSectionList sectionList = new FrmSectionList();
            sectionList.MdiParent = this;
            sectionList.Show();
        }

        private void btnNewSection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewSection section = new FrmNewSection();
            section.Show();
        }

        private void btnNewAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewAuthor author = new FrmNewAuthor();
            author.Show();
        }

        private void btnPublisherList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPublisherList publisherList = new FrmPublisherList();
            publisherList.MdiParent = this;
            publisherList.Show();
        }

        private void btnNewPublisher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewPublisher publisher = new FrmNewPublisher();
            publisher.Show();
        }

        private void btnNewStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNewStudent student = new FrmNewStudent();
            student.Show();
        }

        private void btnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnSnippingTool_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("snippingtool.exe");
        }

        private void btnHomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.MdiParent = this;
            frmHomePage.Show();
        }

        private void btnExchange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmExchange exchange = new FrmExchange();
            exchange.MdiParent = this;
            exchange.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void btnExchange_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmExchange exchange = new FrmExchange();
            exchange.MdiParent = this;
            exchange.Show();
        }

        private void btnYoutube_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYoutube youtube = new FrmYoutube();
            youtube.MdiParent = this;
            youtube.Show();
        }

        private void btnNoteList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNote note = new FrmNote();
            note.MdiParent = this;
            note.Show();
        }
    }
}