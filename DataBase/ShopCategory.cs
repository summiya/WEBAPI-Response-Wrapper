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
    
    public partial class ShopCategory
    {
        public System.Guid shoCatID { get; set; }
        public string shoCatName { get; set; }
        public string shoCatNameAr { get; set; }
        public string shoCatDescription { get; set; }
        public string shoCatDescriptionAr { get; set; }
        public string shoCatImg { get; set; }
        public string shoCatParentID { get; set; }
        public Nullable<int> shoCatPosition { get; set; }
        public Nullable<int> shoCatLevel { get; set; }
        public Nullable<int> shoCatChildrenCount { get; set; }
        public string shoCatSeoName { get; set; }
        public string shoCatIcon { get; set; }
        public Nullable<System.DateTime> shoCatCreatedOn { get; set; }
        public string shoCatCreatedBy { get; set; }
        public Nullable<System.DateTime> shoCatModifiedOn { get; set; }
        public string shoCatModifiedBy { get; set; }
        public Nullable<bool> shoCatIsDeleted { get; set; }
        public Nullable<bool> shoCatIsActive { get; set; }
    }
}
