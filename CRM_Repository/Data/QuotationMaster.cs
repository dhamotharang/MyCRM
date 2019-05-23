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
    
    public partial class QuotationMaster
    {
        public QuotationMaster()
        {
            this.QuotationItemMasters = new HashSet<QuotationItemMaster>();
        }
    
        public int QuotationId { get; set; }
        public string QuotationNo { get; set; }
        public int CompanyId { get; set; }
        public System.DateTime QuotationDate { get; set; }
        public int InqId { get; set; }
        public decimal Total { get; set; }
        public Nullable<decimal> ExRate { get; set; }
        public Nullable<decimal> ExTotal { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> ExCurrencyId { get; set; }
        public int DeliveryTermId { get; set; }
        public string DeliveryTerm { get; set; }
        public Nullable<int> TermPlaceId { get; set; }
        public string TermPlace { get; set; }
        public int PaymentTermId { get; set; }
        public string PaymentTerm { get; set; }
        public System.DateTime OfferValiddate { get; set; }
        public int QuotationMadeBy { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsActive { get; set; }
    
        public virtual CompanyMaster CompanyMaster { get; set; }
        public virtual DeliveryTermsMaster DeliveryTermsMaster { get; set; }
        public virtual InquiryMaster InquiryMaster { get; set; }
        public virtual PaymentTermsMaster PaymentTermsMaster { get; set; }
        public virtual PortMaster PortMaster { get; set; }
        public virtual ICollection<QuotationItemMaster> QuotationItemMasters { get; set; }
    }
}