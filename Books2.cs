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
    
    public partial class Books2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string ISBN { get; set; }
        public string PublicationYear { get; set; }
        public string Edition { get; set; }
        public string LanguageId { get; set; }
        public Nullable<int> PrintLenght { get; set; }
        public string QRCode { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> NumberOfRentals { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> BookCategoryId { get; set; }
        public Nullable<int> SectionId { get; set; }
        public Nullable<bool> BookState { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string Note { get; set; }
    }
}
