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
    
    public partial class ProductGallary
    {
        public System.Guid proGalID { get; set; }
        public string proID { get; set; }
        public string proGalImgName { get; set; }
        public Nullable<System.DateTime> proGalCreatedOn { get; set; }
        public string proGalCreatedBy { get; set; }
        public Nullable<System.DateTime> proGalModifiedOn { get; set; }
        public string proGalModifiedBy { get; set; }
        public Nullable<bool> proGalIsDeleted { get; set; }
        public Nullable<bool> proGalIsActive { get; set; }
    }
}
