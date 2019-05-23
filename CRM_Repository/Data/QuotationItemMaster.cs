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
    
    public partial class QuotationItemMaster
    {
        public int ItemId { get; set; }
        public int QuotationId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string ProductDescription { get; set; }
        public decimal OfferPrice { get; set; }
        public int QtyCode { get; set; }
        public decimal Qty { get; set; }
        public decimal Total { get; set; }
        public bool IsActive { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<decimal> DealerPrice { get; set; }
        public Nullable<int> PriceId { get; set; }
    
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual ProductPrice ProductPrice { get; set; }
        public virtual QuotationMaster QuotationMaster { get; set; }
        public virtual UnitMaster UnitMaster { get; set; }
    }
}