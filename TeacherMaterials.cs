//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliothek
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherMaterials
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string ISBN { get; set; }
        public string PublicationYear { get; set; }
        public string Edition { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> PrintLenght { get; set; }
        public string QRCode { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<int> BookClassId { get; set; }
        public Nullable<int> BookCategoryId { get; set; }
        public Nullable<int> SectionId { get; set; }
        public Nullable<int> BookCategoryTypeId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string Note { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual BooksByCategories BooksByCategories { get; set; }
        public virtual ClassesOfBooks ClassesOfBooks { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual Lessons Lessons { get; set; }
        public virtual Publishers Publishers { get; set; }
        public virtual Section Section { get; set; }
        public virtual TypesOfBookCategories TypesOfBookCategories { get; set; }
    }
}
