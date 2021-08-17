using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void BookList_Load(object sender, EventArgs e)
        {
            //Listeleme
            var values = db.Books.ToList();
            gridControl1.DataSource = values;
        }
    }
}
