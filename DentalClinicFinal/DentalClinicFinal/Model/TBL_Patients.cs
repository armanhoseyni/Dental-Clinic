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
    
    public partial class TBL_Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Patients()
        {
            this.TBL_Appointment = new HashSet<TBL_Appointment>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string famliy { get; set; }
        public string address { get; set; }
        public string tell { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Appointment> TBL_Appointment { get; set; }
    }
}
