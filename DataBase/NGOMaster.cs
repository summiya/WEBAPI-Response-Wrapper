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
    
    public partial class NGOMaster
    {
        public System.Guid ngoID { get; set; }
        public string ngoName { get; set; }
        public string ngoNameAr { get; set; }
        public string ngoImgName { get; set; }
        public Nullable<System.DateTime> ngoCreatedOn { get; set; }
        public string ngoCreatedBy { get; set; }
        public Nullable<System.DateTime> ngoModifiedOn { get; set; }
        public string ngoModifiedBy { get; set; }
        public Nullable<bool> ngoIsDeleted { get; set; }
        public Nullable<bool> ngoIsActive { get; set; }
    }
}
