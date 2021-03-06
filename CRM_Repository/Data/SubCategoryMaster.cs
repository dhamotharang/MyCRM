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
    
    public partial class SubCategoryMaster
    {
        public SubCategoryMaster()
        {
            this.MainProductMasters = new HashSet<MainProductMaster>();
            this.ProductMasters = new HashSet<ProductMaster>();
            this.RNDProductMasters = new HashSet<RNDProductMaster>();
        }
    
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Photo { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual CategoryMaster CategoryMaster { get; set; }
        public virtual ICollection<MainProductMaster> MainProductMasters { get; set; }
        public virtual ICollection<ProductMaster> ProductMasters { get; set; }
        public virtual ICollection<RNDProductMaster> RNDProductMasters { get; set; }
    }
}
