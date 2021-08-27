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
            lueGender.Properties.DataSource = (from x in db.Gender
                                               select new
                                               {
                                                   x.Id,
                                                   Geschlecht = x.Type
                                               }).ToList();

            lueClass.Properties.DataSource = (from x in db.CurrentClasses
                                              select new
                                              {
                                                  x.Id,
                                                  Klasse = x.ClassName
                                              }).ToList();

            lueSchool.Properties.DataSource = (from x in db.Schools
                                               select new
                                               {
                                                   x.Id,
                                                   Schule = x.SchoolName
                                               }).ToList();

            lueUserRole.Properties.DataSource = (from x in db.Roles
                                                 select new
                                                 {
                                                     x.Id,
                                                     BenutzerRolle = x.Name
                                                 }).ToList();

            lueCountry.Properties.DataSource = (from x in db.Countries
                                                select new
                                                {
                                                    x.Id,
                                                    Land = x.CountryName
                                                }).ToList();

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
            lueGender.EditValue = gridView1.GetFocusedRowCellValue("Geschlect").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            txtLastSchoolYear.Text = gridView1.GetFocusedRowCellValue("LetztesSchulJahr").ToString();
            rtxtNote.Text = gridView1.GetFocusedRowCellValue("Note").ToString();
            lueClass.EditValue = gridView1.GetFocusedRowCellValue("Klasse").ToString();
            lueCountry.EditValue = gridView1.GetFocusedRowCellValue("Land").ToString();
            lueSchool.EditValue = gridView1.GetFocusedRowCellValue("Schule").ToString();
            lueUserRole.EditValue = gridView1.GetFocusedRowCellValue("Rolle").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            if (txtFirstName.Text.Length != null && txtFirstName.Text.Length <= 30 && txtLastName.Text.Length != null && txtLastName.Text.Length <= 30 && lueClass.Text.Length != null && lueSchool.Text.Length != null && lueUserRole.Text.Length != null && lueCountry.Text.Length != null && lueGender.Text.Length != null)
            {
                students.FirstName = txtFirstName.Text;
                students.LastName = txtLastName.Text;
                students.GenderId = byte.Parse(lueGender.EditValue.ToString());
                students.LastSchoolYear = txtLastSchoolYear.Text;
                students.ClassId = byte.Parse(lueClass.EditValue.ToString());
                students.SchoolId = byte.Parse(lueSchool.EditValue.ToString());
                students.RoleId = byte.Parse(lueUserRole.EditValue.ToString());
                students.CountryId = byte.Parse(lueCountry.EditValue.ToString());
                students.Note = rtxtNote.Text;

                db.Students.Add(students);
                db.SaveChanges();
                MessageBox.Show("Schüler/in erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Schüler/in konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Students.Find(id);

            if (txtFirstName.Text.Length != null && txtFirstName.Text.Length <= 30 && txtLastName.Text.Length != null && txtLastName.Text.Length <= 30 && lueClass.Text.Length != null && lueSchool.Text.Length != null && lueUserRole.Text.Length != null && lueCountry.Text.Length != null && lueGender.Text.Length != null)
            {
                value.FirstName = txtFirstName.Text;
                value.LastName = txtLastName.Text;
                //value.GenderId = byte.Parse(lueGender.EditValue.ToString());
                value.LastSchoolYear = txtLastSchoolYear.Text;
                value.Description = txtDescription.Text;
                //value.ClassId = byte.Parse(lueClass.EditValue.ToString());
                //value.SchoolId = byte.Parse(lueSchool.EditValue.ToString());
                //value.RoleId = byte.Parse(lueUserRole.EditValue.ToString());
                //value.CountryId = byte.Parse(lueCountry.EditValue.ToString());
                value.IsActive = true;
                value.Note = rtxtNote.Text;

                db.SaveChanges();
                MessageBox.Show("Schüler/in erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Schüler/in erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Students.Find(id);
            db.Students.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Buch erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            StudentList();
        }
    }
}