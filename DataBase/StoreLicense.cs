//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreLicense
    {
        public System.Guid stoLicID { get; set; }
        public string stoID { get; set; }
        public string stoLicEmirateIDName { get; set; }
        public string stoLicEmiratesIDNumber { get; set; }
        public string stoLicEmiratesExpirydate { get; set; }
        public string stoLicETraderLicenseNumber { get; set; }
        public string stoLicETraderLicenseExpirydate { get; set; }
        public string stoLicETraderRegisteredActivity { get; set; }
        public Nullable<System.DateTime> stoLicCreatedOn { get; set; }
        public string stoLicCreatedBy { get; set; }
        public Nullable<System.DateTime> stoLicModifiedOn { get; set; }
        public string stoLicModifiedBy { get; set; }
        public Nullable<bool> stoLicIsActive { get; set; }
        public Nullable<bool> stoLicIsDeleted { get; set; }
    }
}
