//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DentalClinicFinal.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_RoleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_RoleType()
        {
            this.TBL_Entrance = new HashSet<TBL_Entrance>();
        }
    
        public int Id { get; set; }
        public string role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Entrance> TBL_Entrance { get; set; }
    }
}
