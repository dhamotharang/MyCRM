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
    
    public partial class PaymentModeMaster
    {
        public PaymentModeMaster()
        {
            this.PerformaPaymentMasters = new HashSet<PerformaPaymentMaster>();
        }
    
        public int PaymentModeId { get; set; }
        public string PaymentMode { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<PerformaPaymentMaster> PerformaPaymentMasters { get; set; }
    }
}
