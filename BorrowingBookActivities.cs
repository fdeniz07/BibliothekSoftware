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
    
    public partial class BorrowingBookActivities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorrowingBookActivities()
        {
            this.BorrowingBooks = new HashSet<BorrowingBooks>();
        }
    
        public int Id { get; set; }
        public int DelayTime { get; set; }
        public bool IsRead { get; set; }
        public Nullable<int> StaffId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string Note { get; set; }
        public bool StatusType { get; set; }
    
        public virtual Penalties Penalties { get; set; }
        public virtual Staves Staves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowingBooks> BorrowingBooks { get; set; }
    }
}