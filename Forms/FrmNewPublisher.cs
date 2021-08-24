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
                Section section = new Section();
                section.SectionName = txtPublisherName.Text;
                section.Details = txtPublisherAbout.Text;
                section.Note = txtNote.Text;
                section.IsActive = true;
                section.IsDeleted = false;

                db.Section.Add(section);
                db.SaveChanges();
                MessageBox.Show("Abteilung erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
