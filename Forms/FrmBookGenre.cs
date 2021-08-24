using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmBookGenre : Form
    {
        public FrmBookGenre()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private SqlConnection connection = new SqlConnection(@"Data Source=APACHIE;Initial Catalog=DamlaLibrary;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        private void FrmBookGenre_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Books.OrderBy(x => x.TypeId).GroupBy(y => y.TypesOfBooks.BookType).Select(z => new
            {
                Buchgenre = z.Key,
                Summe = z.Count()
            }).ToList();

            connection.Open();
            SqlCommand cmd = new SqlCommand("select TypeId,Count(*) from Books group by TypeId", connection);
            SqlCommand cmd1 = new SqlCommand("select T.BookType,Count(*) from Books as B inner join  TypesOfBooks as T on B.TypeId = T.id group by t.BookType", connection);

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            connection.Close();
        }
    }
}