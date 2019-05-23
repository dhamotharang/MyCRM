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
    
    public partial class PurchaseOrderMaster
    {
        public PurchaseOrderMaster()
        {
            this.PurchaseOrderDetailMasters = new HashSet<PurchaseOrderDetailMaster>();
        }
    
        public int PoId { get; set; }
        public string PoNo { get; set; }
        public string PoRefNo { get; set; }
        public System.DateTime PoDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> TermsConditionId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal PayableAmount { get; set; }
        public Nullable<int> ModeOfShipmentId { get; set; }
        public Nullable<int> PriceCode { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> LandingPort { get; set; }
        public Nullable<int> DischargePort { get; set; }
        public int SupplierId { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Attn { get; set; }
        public string AttnMobile { get; set; }
        public string AttnEmail { get; set; }
        public int ComId { get; set; }
        public Nullable<int> BuyerId { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerTel { get; set; }
        public string BuyerFax { get; set; }
        public string BuyerWebsite { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerAttn { get; set; }
        public string BuyerAttnMobile { get; set; }
        public string BuyerAttnEmail { get; set; }
        public string BuyerTax { get; set; }
        public string SupplierTax { get; set; }
        public string BuyerExcise { get; set; }
        public Nullable<int> DeliveryTermId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<int> BusTermsPortId { get; set; }
        public Nullable<int> BusTermsLicenseId { get; set; }
        public string BusTermsLicenseValue { get; set; }
        public string BusTermsDesc { get; set; }
        public string TotalNoOfpckg { get; set; }
        public string DiameterOfCartoon { get; set; }
        public Nullable<int> ModeOfShipping { get; set; }
        public string BuyerContactperson { get; set; }
        public string SupplierContactperson { get; set; }
    
        public virtual BuyerMaster BuyerMaster { get; set; }
        public virtual CompanyMaster CompanyMaster { get; set; }
        public virtual CurrencyMaster CurrencyMaster { get; set; }
        public virtual DeliveryTermsMaster DeliveryTermsMaster { get; set; }
        public virtual LicenseMaster LicenseMaster { get; set; }
        public virtual PortMaster PortMaster { get; set; }
        public virtual ICollection<PurchaseOrderDetailMaster> PurchaseOrderDetailMasters { get; set; }
        public virtual ShipmentMaster ShipmentMaster { get; set; }
        public virtual ShipmentMaster ShipmentMaster1 { get; set; }
        public virtual TermsAndConditionMaster TermsAndConditionMaster { get; set; }
    }
}
