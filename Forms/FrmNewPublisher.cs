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
    public partial class FrmNewPublisher : Form
    {
        public FrmNewPublisher()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int counter = 0;

            var query = (from x in db.Publishers select x.PublisherName).Distinct();

            foreach (var data in query)
            {
                if (data.Equals(txtPublisherName.Text))
                    counter++;
            }

            if (counter != 0)
                MessageBox.Show("Diese Abteilung ist existiert", "Warnung", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                Publishers publishers = new Publishers();

                if (txtPublisherName.Text.Length!=null && txtPublisherName.Text.Length<=50 && txtPublisherAbout.Text.Length<=250)
                {
                    publishers.PublisherName = txtPublisherName.Text;
                    publishers.PublisherAbout = txtPublisherAbout.Text;
                    publishers.Note = txtNote.Text;
                    publishers.IsActive = true;
                    publishers.IsDeleted = false;

                    db.Publishers.Add(publishers);
                    db.SaveChanges();
                    MessageBox.Show("Abteilung erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abteilung konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
