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
    
    public partial class ShopCategoryMapping
    {
        public System.Guid shoCatMapID { get; set; }
        public string shoCatID { get; set; }
        public string stoID { get; set; }
        public Nullable<System.DateTime> shoCatMapCreatedOn { get; set; }
        public string shoCatMapCreatedBy { get; set; }
        public Nullable<System.DateTime> shoCatMapModifiedOn { get; set; }
        public string shoCatMapModifiedBy { get; set; }
        public Nullable<bool> shoCatMapIsDeleted { get; set; }
        public Nullable<bool> shoCatMapIsActive { get; set; }
    }
}
