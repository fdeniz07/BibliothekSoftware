using System;
using System.Linq;
using System.Windows.Forms;

namespace Bibliothek.Forms
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            StudentList();
            lueGender.Properties.DataSource = db.Gender.ToList();
            lueClass.Properties.DataSource = db.CurrentClasses.ToList();
            lueSchool.Properties.DataSource = db.Schools.ToList();
            lueUserRole.Properties.DataSource = db.Roles.ToList();
            lueCountry.Properties.DataSource = db.Countries.ToList();
        }

        void StudentList()
        {
            var values = from students in db.Students
                select new
                {
                    students.Id,
                    Vorname= students.FirstName,
                    Nachname=students.LastName,
                    Geschlect=students.Gender.Type,
                    LetztesSchulJahr = students.LastSchoolYear,
                    Beschreibung=students.Description,
                    Klasse=students.CurrentClasses.ClassName,
                    Schule=students.Schools.SchoolName,
                    Rolle=students.Roles.Name,
                    Land=students.Countries.CountryName,
                    Status=students.IsActive,
                    students.Note
                };
            gridControl1.DataSource = values.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtFirstName.Text = gridView1.GetFocusedRowCellValue("Vorname").ToString();
            txtLastName.Text = gridView1.GetFocusedRowCellValue("Nachname").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            txtLastSchoolYear.Text = gridView1.GetFocusedRowCellValue("LetztesSchulJahr").ToString();
            rtxtNote.Text = gridView1.GetFocusedRowCellValue("Note").ToString();
        }
    }
}
