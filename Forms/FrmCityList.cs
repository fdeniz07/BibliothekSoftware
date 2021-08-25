using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmCityList : Form
    {
        public FrmCityList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmCityList_Load(object sender, EventArgs e)
        {
            CityList();
            lueState.Properties.DataSource= (from x in db.States
                select new
                {
                    x.Id,
                    Bundesland = x.StateName,
                    BundeslandCode = x.StateCode
                }).ToList();
        }

        private void CityList()
        {
            var values = from cities in db.Cities
                select new
                {
                    cities.Id,
                    Stadt = cities.CityName,
                    PLZ = cities.PostCode,
                    Bundesland = cities.States.StateName
                };
            gridControl1.DataSource = values.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cities cities = new Cities();

            if (txtPostCode.Text.Length <= 5)
            {
                cities.CityName = txtCityName.Text;
                cities.PostCode = txtPostCode.Text;
                cities.StateId = byte.Parse(lueState.EditValue.ToString());

                db.Cities.Add(cities);
                db.SaveChanges();
                MessageBox.Show("Die Stadt erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Die Stadt erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CityList();
        }
    }
}
