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
    
    public partial class TBL_Appointment
    {
        public int Id { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public Nullable<int> DocVisitId { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual TBL_desntistsWorkTime TBL_desntistsWorkTime { get; set; }
        public virtual TBL_Patients TBL_Patients { get; set; }
        public virtual TBL_Services TBL_Services { get; set; }
        public virtual TBL_User TBL_User { get; set; }
    }
}
