﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_dentist_clinicEntitiess : DbContext
    {
        public DB_dentist_clinicEntitiess()
            : base("name=DB_dentist_clinicEntitiess")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_Appointment> TBL_Appointment { get; set; }
        public virtual DbSet<TBL_ClinicDateTable> TBL_ClinicDateTable { get; set; }
        public virtual DbSet<TBL_DentistType> TBL_DentistType { get; set; }
        public virtual DbSet<TBL_desntistsWorkTime> TBL_desntistsWorkTime { get; set; }
        public virtual DbSet<TBL_doctors> TBL_doctors { get; set; }
        public virtual DbSet<TBL_Entrance> TBL_Entrance { get; set; }
        public virtual DbSet<TBL_Patients> TBL_Patients { get; set; }
        public virtual DbSet<TBL_RoleType> TBL_RoleType { get; set; }
        public virtual DbSet<TBL_Sections> TBL_Sections { get; set; }
        public virtual DbSet<TBL_Services> TBL_Services { get; set; }
        public virtual DbSet<TBL_User> TBL_User { get; set; }
    }
}
