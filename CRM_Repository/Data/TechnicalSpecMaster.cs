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
    
    public partial class TechnicalSpecMaster
    {
        public TechnicalSpecMaster()
        {
            this.ProductParameterMasters = new HashSet<ProductParameterMaster>();
            this.PurchaseOrderTechnicalDetails = new HashSet<PurchaseOrderTechnicalDetail>();
            this.SalesTechnicalDetailMasters = new HashSet<SalesTechnicalDetailMaster>();
            this.TOTechnicalDetails = new HashSet<TOTechnicalDetail>();
        }
    
        public int SpecificationId { get; set; }
        public string TechSpec { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> TechHeadId { get; set; }
    
        public virtual ICollection<ProductParameterMaster> ProductParameterMasters { get; set; }
        public virtual ICollection<PurchaseOrderTechnicalDetail> PurchaseOrderTechnicalDetails { get; set; }
        public virtual ICollection<SalesTechnicalDetailMaster> SalesTechnicalDetailMasters { get; set; }
        public virtual TechnicalSpecHeadMaster TechnicalSpecHeadMaster { get; set; }
        public virtual ICollection<TOTechnicalDetail> TOTechnicalDetails { get; set; }
    }
}
