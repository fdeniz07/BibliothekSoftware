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
    public partial class FrmPublisherList : Form
    {
        public FrmPublisherList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmPublisherList_Load(object sender, EventArgs e)
        {
            PublisherList();
        }

        private void PublisherList()
        {
            var values = from publisher in db.Publishers
                select new
                {
                    publisher.Id,
                    Verlag = publisher  .PublisherName,
                    VerlagDetail = publisher.PublisherAbout,
                    Status = publisher.IsActive,
                    Erläuterung = publisher.Note
                };
            gridControl1.DataSource = values.ToList();
        }

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
                MessageBox.Show("Dieser Verlag ist existiert", "Warnung", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                Publishers publishers = new Publishers();
                publishers.PublisherName = txtPublisherName.Text;
                publishers.PublisherAbout = txtPublisherAbout.Text;
                publishers.Note = rtxtNote.Text;
                publishers.IsActive = true;
                publishers.IsDeleted = false;

                db.Publishers.Add(publishers);
                db.SaveChanges();
                MessageBox.Show("Verlag erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Publishers.Find(id);
            value.PublisherName = txtPublisherName.Text;
            value.PublisherAbout = txtPublisherAbout.Text;
            value.Note = rtxtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Verlag erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Publishers.Find(id);
            db.Publishers.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Verlag erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            PublisherList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtPublisherName.Text = gridView1.GetFocusedRowCellValue("Verlag").ToString();
            txtPublisherAbout.Text = gridView1.GetFocusedRowCellValue("VerlagDetail").ToString();
            rtxtNote.Text = gridView1.GetFocusedRowCellValue("Erläuterung").ToString();
        }
    }
}
