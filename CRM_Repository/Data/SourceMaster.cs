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
    
    public partial class SourceMaster
    {
        public SourceMaster()
        {
            this.AskCustomerDetails = new HashSet<AskCustomerDetail>();
            this.InquiryMasters = new HashSet<InquiryMaster>();
            this.UserMasters = new HashSet<UserMaster>();
        }
    
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<AskCustomerDetail> AskCustomerDetails { get; set; }
        public virtual ICollection<InquiryMaster> InquiryMasters { get; set; }
        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}
