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
    
    public partial class StoresTax
    {
        public System.Guid stoTaxID { get; set; }
        public string stoID { get; set; }
        public string stoTaxName { get; set; }
        public string stoTaxType { get; set; }
        public Nullable<double> stoTaxValue { get; set; }
        public Nullable<bool> stoTaxIsDefault { get; set; }
        public Nullable<System.DateTime> stoTaxCreatedOn { get; set; }
        public string stoTaxCreatedBy { get; set; }
        public Nullable<System.DateTime> stoTaxModifiedOn { get; set; }
        public string stoTaxModifiedBy { get; set; }
        public Nullable<bool> stoTaxIsDeleted { get; set; }
        public Nullable<bool> stoTaxIsActive { get; set; }
    }
}
