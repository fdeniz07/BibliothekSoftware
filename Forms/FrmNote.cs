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
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmNote_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource =
        }
    }
}
