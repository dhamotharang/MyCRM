//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhotoMaster
    {
        public int PhotoId { get; set; }
        public int ProductId { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int IsDefault { get; set; }
        public Nullable<int> CatalogId { get; set; }
    
        public virtual ProductCatalogMaster ProductCatalogMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
    }
}
