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
    
    public partial class TBL_ClinicDateTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_ClinicDateTable()
        {
            this.TBL_desntistsWorkTime = new HashSet<TBL_desntistsWorkTime>();
        }
    
        public int id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_desntistsWorkTime> TBL_desntistsWorkTime { get; set; }
    }
}
