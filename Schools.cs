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
    
    public partial class Schools
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schools()
        {
            this.Students = new HashSet<Students>();
        }
    
        public short Id { get; set; }
        public string SchoolName { get; set; }
        public Nullable<short> SchoolTypeId { get; set; }
    
        public virtual SchoolTypes SchoolTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }
    }
}
