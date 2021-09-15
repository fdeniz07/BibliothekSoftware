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
    
    public partial class BooksByCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BooksByCategories()
        {
            this.Books = new HashSet<Books>();
            this.TeacherMaterials = new HashSet<TeacherMaterials>();
        }
    
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Books> Books { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherMaterials> TeacherMaterials { get; set; }
    }
}
