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
    
    public partial class SuperAdminLogin
    {
        public System.Guid supAdmLogID { get; set; }
        public string supAdmLogUserName { get; set; }
        public string supAdmLogPassword { get; set; }
        public Nullable<System.DateTime> supAdmLogCreatedOn { get; set; }
        public string supAdmLogCreatedBy { get; set; }
        public Nullable<System.DateTime> supAdmLogModifiedOn { get; set; }
        public string supAdmLogModifiedBy { get; set; }
        public Nullable<bool> supAdmLogIsDeleted { get; set; }
        public Nullable<bool> supAdmLogIsActive { get; set; }
    }
}
