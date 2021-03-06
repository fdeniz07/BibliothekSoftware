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
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.BorrowingBooks = new HashSet<BorrowingBooks>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public string LastSchoolYear { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int ClassId { get; set; }
        public int SchoolId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int CountryId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchived { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowingBooks> BorrowingBooks { get; set; }
        public virtual Countries Countries { get; set; }
        public virtual CurrentClasses CurrentClasses { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Schools Schools { get; set; }
    }
}
