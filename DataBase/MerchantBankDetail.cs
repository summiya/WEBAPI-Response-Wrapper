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
    
    public partial class MerchantBankDetail
    {
        public System.Guid merBanDetID { get; set; }
        public string merID { get; set; }
        public string merBanDetAccountName { get; set; }
        public string merBanDetBankName { get; set; }
        public string merBanDetBranchName { get; set; }
        public string merBanDetIBANNo { get; set; }
        public string merBanDetSWIFTCode { get; set; }
        public Nullable<System.DateTime> merBanDetCreatedOn { get; set; }
        public string merBanDetCreatedBy { get; set; }
        public Nullable<System.DateTime> merBanDetModifiedOn { get; set; }
        public string merBanDetModifiedBy { get; set; }
        public Nullable<bool> merBanDetIsDeleted { get; set; }
        public Nullable<bool> merBanDetIsActive { get; set; }
        public Nullable<bool> merBanAlternativePay { get; set; }
    }
}
