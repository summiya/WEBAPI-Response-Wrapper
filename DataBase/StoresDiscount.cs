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
    
    public partial class StoresDiscount
    {
        public System.Guid stoDisID { get; set; }
        public string stoID { get; set; }
        public string stoDisName { get; set; }
        public string stoDisType { get; set; }
        public Nullable<double> stoDisValue { get; set; }
        public Nullable<bool> stoDisIsDefault { get; set; }
        public string stoDisFromDate { get; set; }
        public string stoDisToDate { get; set; }
        public Nullable<System.DateTime> stoDisCreatedOn { get; set; }
        public string stoDisCreatedBy { get; set; }
        public Nullable<System.DateTime> stoDisModifiedOn { get; set; }
        public string stoDisModifiedBy { get; set; }
        public Nullable<bool> stoDisIsDeleted { get; set; }
        public Nullable<bool> stoDisIsActive { get; set; }
    }
}
