using System;
using System.Linq;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace Bibliothek.Forms
{
    public partial class FrmTeacherMaterielList : Form
    {
        public FrmTeacherMaterielList()
        {
            InitializeComponent();
        }

        private DamlaLibraryEntities db = new DamlaLibraryEntities();

        private void FrmTeacherMaterielList_Load(object sender, EventArgs e)
        {
            ToTeacherMaterielList();
            lueAuthor.Properties.DataSource = (from x in db.Authors
                                               select new
                                               {
                                                   x.Id,
                                                   Vollname = x.FullName
                                               }).ToList();//db.Authors.ToList();
            luePublisher.Properties.DataSource = (from x in db.Publishers
                                                  select new
                                                  {
                                                      x.Id,
                                                      Verlag = x.PublisherName
                                                  }).ToList();//db.Publishers.ToList();
            lueLesson.Properties.DataSource = (from x in db.Lessons
                                               select new
                                               {
                                                   x.Id,
                                                   Fach = x.Lesson
                                               }).ToList();
            lueLesson.Properties.DataSource = (from x in db.Lessons
                                               select new
                                               {
                                                   x.Id,
                                                   Klasse = x.Lesson
                                               }).ToList();
            lueBookCategory.Properties.DataSource = (from x in db.BooksByCategories
                                                     select new
                                                     {
                                                         x.Id,
                                                         Buchkategorie = x.Category
                                                     }).ToList();//db.TypesOfBooks.ToList();
            lueSection.Properties.DataSource = (from x in db.Section
                                                select new
                                                {
                                                    x.Id,
                                                    Abteilung = x.SectionName
                                                }).ToList();//db.Section.ToList();
            lueLanguage.Properties.DataSource = (from x in db.Languages
                                                 select new
                                                 {
                                                     x.Id,
                                                     Sprache = x.Language
                                                 }).ToList();
            lueBookClass.Properties.DataSource = (from x in db.ClassesOfBooks
                select new
                {
                    x.Id,
                    Typ = x.Class
                }).ToList();
            lueBookCategoryType.Properties.DataSource = (from x in db.TypesOfBookCategories
                select new
                {
                    x.Id,
                    Typ = x.CategoryName
                }).ToList();
        }

        private void ToTeacherMaterielList()
        {
            var values = from teacherMaterials in db.TeacherMaterials
                         select new
                         {
                             teacherMaterials.Id,
                             Buchtitel = teacherMaterials.Title,
                             Beschreibung = teacherMaterials.Description,
                             Zusammenfassung = teacherMaterials.Summary,
                             teacherMaterials.ISBN,
                             Erscheinungsjahr = teacherMaterials.PublicationYear,
                             Auflage = teacherMaterials.Edition,
                             Sprache = teacherMaterials.Languages.Language,
                             Drucklänge = teacherMaterials.PrintLenght,
                             Autor = teacherMaterials.Authors.FullName,
                             Verlag = teacherMaterials.Publishers.PublisherName,
                             Fach = teacherMaterials.Lessons.Lesson,
                             Klasse = teacherMaterials.ClassesOfBooks.Class,
                             Buchkategorie = teacherMaterials.BooksByCategories.Category,
                             Abteilung = teacherMaterials.Section.SectionName,
                             Typ = teacherMaterials.TypesOfBookCategories.CategoryName,
                             QRCode = teacherMaterials.QRCode,
                             Status = teacherMaterials.IsActive,
                             Erläuterung = teacherMaterials.Note
                         };
            gridControl1.DataSource = values.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TeacherMaterials teacherMaterials = new TeacherMaterials();

            if (txtBookName.Text.Length != null && txtBookName.Text.Length <= 50 && txtDescription.Text.Length <= 250 && lueAuthor.Text.Length != null && lueLesson.Text.Length != null && luePublisher.Text.Length != null && lueBookCategory.Text.Length != null && lueSection.Text.Length != null && lueBookClass.Text.Length != null && lueBookCategoryType.Text.Length != null && lueLanguage.Text.Length != null)
            {
                teacherMaterials.Title = txtBookName.Text;
                teacherMaterials.Description = txtDescription.Text;
                teacherMaterials.Summary = rtxtSummary.Text;
                teacherMaterials.ISBN = txtISBN.Text;
                teacherMaterials.PublicationYear = txtPublicationYear.Text;
                teacherMaterials.Edition = txtEdition.Text;
                teacherMaterials.LanguageId = byte.Parse(lueLanguage.EditValue.ToString());
                teacherMaterials.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
                teacherMaterials.AuthorId = byte.Parse(lueAuthor.EditValue.ToString());
                teacherMaterials.PublisherId = byte.Parse(luePublisher.EditValue.ToString());
                teacherMaterials.LessonId = byte.Parse(lueLesson.EditValue.ToString());
                teacherMaterials.BookClassId = byte.Parse(lueBookClass.EditValue.ToString());
                teacherMaterials.BookCategoryId = byte.Parse(lueBookCategory.EditValue.ToString());
                teacherMaterials.SectionId = byte.Parse(lueSection.EditValue.ToString());
                teacherMaterials.QRCode = txtQRCode.Text;
                teacherMaterials.Note = txtNote.Text;
                teacherMaterials.IsActive = true;
                teacherMaterials.IsDeleted = false;

                db.TeacherMaterials.Add(teacherMaterials);
                db.SaveChanges();
                MessageBox.Show("Lehrmaterial erfolgreich gespeichert", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lehrmaterial konnte nicht gespeichert werden", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.TeacherMaterials.Find(id);
            value.Title = txtBookName.Text;
            value.Description = txtDescription.Text;
            value.Summary = rtxtSummary.Text;
            value.ISBN = txtISBN.Text;
            value.PublicationYear = txtPublicationYear.Text;
            value.Edition = txtEdition.Text;
            value.PrintLenght = Convert.ToInt32(txtPrintLenght.Text);
            value.QRCode = txtQRCode.Text;
            value.Note = txtNote.Text;

            db.SaveChanges();
            MessageBox.Show("Lehrmaterial erfolgreich aktualisiert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ToTeacherMaterielList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.TeacherMaterials.Find(id);
            db.TeacherMaterials.Remove(value);

            db.SaveChanges();
            MessageBox.Show("Lehrmaterial erfolgreich gelöscht!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBookName.Text = gridView1.GetFocusedRowCellValue("Buchtitel").ToString();
            txtDescription.Text = gridView1.GetFocusedRowCellValue("Beschreibung").ToString();
            rtxtSummary.Text = gridView1.GetFocusedRowCellValue("Zusammenfassung").ToString();
            txtISBN.Text = gridView1.GetFocusedRowCellValue("ISBN").ToString();
            txtPublicationYear.Text = gridView1.GetFocusedRowCellValue("Erscheinungsjahr").ToString();
            txtEdition.Text = gridView1.GetFocusedRowCellValue("Auflage").ToString();
            //txtLanguage.Text = gridView1.GetFocusedRowCellValue("Sprache").ToString();
            txtPrintLenght.Text = gridView1.GetFocusedRowCellValue("Drucklänge").ToString();
            txtQRCode.Text = gridView1.GetFocusedRowCellValue("QRCode").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Erläuterung").ToString();
            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureEdit1.Image = encoder.Encode(txtQRCode.Text);
        }
    }
}
