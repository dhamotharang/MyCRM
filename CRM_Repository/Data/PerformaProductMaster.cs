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
    
    public partial class PerformaProductMaster
    {
        public int Id { get; set; }
        public int PerformaInvId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductModelNo { get; set; }
        public Nullable<int> CountryOfOriginId { get; set; }
        public string ProductDescription { get; set; }
        public int QtyCode { get; set; }
        public decimal Qty { get; set; }
        public int CurrencyCode { get; set; }
        public decimal DealerPrice { get; set; }
        public decimal AddPerValue { get; set; }
        public decimal OfferPrice { get; set; }
        public bool IsActive { get; set; }
    
        public virtual CountryOfOriginMaster CountryOfOriginMaster { get; set; }
        public virtual CurrencyMaster CurrencyMaster { get; set; }
        public virtual PerformaInvoiceMaster PerformaInvoiceMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UnitMaster UnitMaster { get; set; }
    }
}
