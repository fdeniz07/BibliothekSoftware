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
    public partial class FrmNewStudent : Form
    {
        public FrmNewStudent()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Students students = new Students();

            if (txtFirstName.Text.Length !=null && txtFirstName.Text.Length<=30 && txtLastName.Text.Length!=null && txtLastName.Text.Length<=30 && lueClass.Text.Length!=null && lueSchool.Text.Length!=null && lueUserRole.Text.Length!=null && lueCountry.Text.Length!=null && lueGender.Text.Length!=null)
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

                if (rbActive.Checked == true && rbPassive.Checked == false)
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
            else
            {
                MessageBox.Show("Schüler/in erfolgreich nicht gespeichert", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmNewStudent student = new FrmNewStudent();
        }

        private void FrmNewStudent_Load(object sender, EventArgs e)
        {
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
    }
}
