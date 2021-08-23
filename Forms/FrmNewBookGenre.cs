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
    public partial class FrmNewBookGenre : Form
    {
        public FrmNewBookGenre()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmNewBookGenre_Load(object sender, EventArgs e)
        {
            BookgenresList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TypesOfBooks types = new TypesOfBooks();

            types.BookType = txtBookGenre.Text;
            types.TypeDetails = txtDescription.Text;
            types.Note = txtNote.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewBook newBook = new FrmNewBook();
        }

        void BookgenresList()
        {
            var values = from types in db.TypesOfBooks
                select new
                {
                    types.Id,
                    types.BookType,
                    types.IsActive,
                    types.Note
                };
        }
    }
}
