//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Magazine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazine()
        {
            this.CheckOuts = new HashSet<CheckOut>();
        }
    
        public int MagazineID { get; set; }
        public string MagTitle { get; set; }
        public string MagDatePublished { get; set; }
        public string IssueNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
    }
}