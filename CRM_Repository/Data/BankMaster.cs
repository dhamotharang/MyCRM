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
    
    public partial class BankMaster
    {
        public int BankId { get; set; }
        public string BeneficiaryName { get; set; }
        public string BranchName { get; set; }
        public string AccountNo { get; set; }
        public string IFSCCode { get; set; }
        public int NickName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsActive { get; set; }
        public string SwiftCode { get; set; }
        public string CRNNo { get; set; }
        public Nullable<int> AccountTypeId { get; set; }
        public string RegisterEmail { get; set; }
        public string RegisterMobile { get; set; }
        public string StatementPassword { get; set; }
        public string BankCustomerCareNo { get; set; }
        public string BankCustomerCareEmail { get; set; }
        public string Note { get; set; }
        public int BankNameId { get; set; }
        public string MICRCode { get; set; }
    
        public virtual AcHolderMaster AcHolderMaster { get; set; }
        public virtual BankNameMaster BankNameMaster { get; set; }
    }
}