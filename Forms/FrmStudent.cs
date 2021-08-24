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

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            StudentList();
            lueGender.Properties.DataSource = db.Gender.ToList();
            lueClass.Properties.DataSource = db.CurrentClasses.ToList();
            lueSchool.Properties.DataSource = db.Schools.ToList();
            lueUserRole.Properties.DataSource = db.Roles.ToList();
            lueCountry.Properties.DataSource = db.Countries.ToList();

            Students students = new Students();
            if (students.IsActive == true)
            {
                rbActive.Checked = true;
                rbPassive.Checked = false;
            }
            else
            {
                rbActive.Checked = false;
                rbPassive.Checked = true;
            }
        }

        private void StudentList()
        {
            var values = from students in db.Students
                         select new
                         {
                             students.Id,
                             Vorname = students.FirstName,
                             Nachname = students.LastName,
                             Geschlect = students.Gender.Type,
                             LetztesSchulJahr = students.LastSchoolYear,
                             Beschreibung = students.Description,
                             Klasse = students.CurrentClasses.ClassName,
                             Schule = students.Schools.SchoolName,
                             Rolle = students.Roles.Name,
                             Land = students.Countries.CountryName,
                             Status = students.IsActive,
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.FirstName = txtFirstName.Text;
            students.LastName = txtLastName.Text;
            students.GenderId = byte.Parse(lueGender.EditValue.ToString());
            students.LastSchoolYear = txtLastSchoolYear.Text;
            students.ClassId = byte.Parse(lueClass.EditValue.ToString());
            students.SchoolId = byte.Parse(lueSchool.EditValue.ToString());
            students.RoleId = byte.Parse(lueUserRole.EditValue.ToString());
            students.CountryId = byte.Parse(lueCountry.EditValue.ToString());
            students.Note = rtxtNote.Text;

            if (rbActive.Checked == true && rbPassive.Checked==false)
            {
                students.IsActive = true;
            }
            else
            {
                students.IsActive = false;
            }

            db.Students.Add(students);
            db.SaveChanges();
            MessageBox.Show("Schüler/in erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }
    }
}