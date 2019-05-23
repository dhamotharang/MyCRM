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
    
    public partial class SalesItemMaster
    {
        public SalesItemMaster()
        {
            this.SalesTechnicalDetailMasters = new HashSet<SalesTechnicalDetailMaster>();
        }
    
        public int ItemId { get; set; }
        public int SOId { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ModelNo { get; set; }
        public int CountryOfOriginId { get; set; }
        public int QtyCode { get; set; }
        public decimal Qty { get; set; }
        public int UnitPriceCode { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; }
    
        public virtual CountryOfOriginMaster CountryOfOriginMaster { get; set; }
        public virtual CurrencyMaster CurrencyMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual SalesOrderMaster SalesOrderMaster { get; set; }
        public virtual UnitMaster UnitMaster { get; set; }
        public virtual ICollection<SalesTechnicalDetailMaster> SalesTechnicalDetailMasters { get; set; }
    }
}