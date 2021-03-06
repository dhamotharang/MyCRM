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
    
    public partial class InquiryMaster
    {
        public InquiryMaster()
        {
            this.InquiryFollowupMasters = new HashSet<InquiryFollowupMaster>();
            this.InquiryItemMasters = new HashSet<InquiryItemMaster>();
            this.QuotationMasters = new HashSet<QuotationMaster>();
            this.TOMasters = new HashSet<TOMaster>();
        }
    
        public int InqId { get; set; }
        public string InqNo { get; set; }
        public System.DateTime InqDate { get; set; }
        public int SourceId { get; set; }
        public int BuyerType { get; set; }
        public string BuyerName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Requirement { get; set; }
        public string Address { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Status { get; set; }
        public string Remark { get; set; }
        public Nullable<int> AssignTo { get; set; }
        public Nullable<int> SubjectType { get; set; }
        public string Subject { get; set; }
        public string ContactPersonname { get; set; }
        public string CompanyName { get; set; }
    
        public virtual CityMaster CityMaster { get; set; }
        public virtual ICollection<InquiryFollowupMaster> InquiryFollowupMasters { get; set; }
        public virtual ICollection<InquiryItemMaster> InquiryItemMasters { get; set; }
        public virtual SourceMaster SourceMaster { get; set; }
        public virtual ICollection<QuotationMaster> QuotationMasters { get; set; }
        public virtual ICollection<TOMaster> TOMasters { get; set; }
    }
}
