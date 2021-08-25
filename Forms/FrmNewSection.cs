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
    public partial class FrmNewSection : Form
    {
        public FrmNewSection()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            int counter = 0;

            var query = (from x in db.Section select x.SectionName).Distinct();

            foreach (var data in query)
            {
                if (data.Equals(txtSectionName.Text))
                    counter++;
            }

            if (counter != 0)
                MessageBox.Show("Diese Abteilung ist existiert", "Warnung", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                Section section = new Section();

                if (txtSectionName.Text.Length!=null && txtSectionName.Text.Length<=50 && txtDescription.Text.Length>=250)
                {
                    section.SectionName = txtSectionName.Text;
                    section.Details = txtDescription.Text;
                    section.Note = txtNote.Text;
                    section.IsActive = true;
                    section.IsDeleted = false;

                    db.Section.Add(section);
                    db.SaveChanges();
                    MessageBox.Show("Abteilung erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Abteilung erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewCategory category = new FrmNewCategory();
        }

        private void FrmNewSection_Load(object sender, EventArgs e)
        {

        }
    }
}
