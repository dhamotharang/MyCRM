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
    
    public partial class ProductParameterMaster
    {
        public int TechDetailId { get; set; }
        public int ProductId { get; set; }
        public int TechParaId { get; set; }
        public string Value { get; set; }
        public Nullable<int> CatalogId { get; set; }
        public string Note { get; set; }
    
        public virtual ProductCatalogMaster ProductCatalogMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual TechnicalSpecMaster TechnicalSpecMaster { get; set; }
    }
}
