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
    public partial class FrmNewAuthor : Form
    {
        public FrmNewAuthor()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int counter = 0;

            //var query = (from x in db.Authors select x.FullName).Distinct();

            //txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;

            //foreach (var data in query)
            //{
            //    if (data.Equals(txtFullName.Text))
            //        counter++;
            //}

            //if (counter != 0)
            //    MessageBox.Show("Autor/in ist existiert", "Warnung", MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //else
            //{}
            Authors authors = new Authors();
            if (txtFirstName.Text.Length <= 50 && txtLastName.Text.Length <= 50)
            {
                authors.FirstName = txtFirstName.Text;
                authors.LastName = txtLastName.Text;
                authors.FullName = txtFirstName.Text + txtLastName.Text;
                authors.AuthorAbout = txtAuthorAbout.Text;
                authors.Note = txtNote.Text;
                authors.IsActive = true;
                authors.IsDeleted = false;

                db.Authors.Add(authors);
                db.SaveChanges();
                MessageBox.Show("Autor/in erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Autor/in  konnte nicht gespeichert werden", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewAuthor newAuthor = new FrmNewAuthor();
        }
    }
}
