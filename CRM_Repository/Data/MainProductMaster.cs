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
    
    public partial class MainProductMaster
    {
        public int MainProductId { get; set; }
        public int SubCategoryId { get; set; }
        public string MainProductName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual SubCategoryMaster SubCategoryMaster { get; set; }
    }
}
