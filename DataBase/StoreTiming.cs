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
    
    public partial class StoreTiming
    {
        public System.Guid stoTimID { get; set; }
        public string stoID { get; set; }
        public string stoTimDayName { get; set; }
        public string stoTimOpeningTime { get; set; }
        public string stoTimClosingTime { get; set; }
        public Nullable<System.DateTime> stoTimCreatedOn { get; set; }
        public string stoTimCreatedBy { get; set; }
        public Nullable<System.DateTime> stoTimModifiedOn { get; set; }
        public string stoTimModifiedBy { get; set; }
        public Nullable<bool> stoTimIsDeleted { get; set; }
        public Nullable<bool> stoTimIsActive { get; set; }
    }
}
