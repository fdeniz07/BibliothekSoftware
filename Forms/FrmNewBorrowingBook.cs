using System;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmNewBorrowingBook : Form
    {
        public FrmNewBorrowingBook()
        {
            InitializeComponent();
        }

      DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnAusLeihe_Click(object sender, EventArgs e)
        {

        }
    }
}
