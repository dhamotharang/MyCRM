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
    
    public partial class AskCustomerDetail
    {
        public int AskCustId { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string Email { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifyedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public string Requirement { get; set; }
    
        public virtual SourceMaster SourceMaster { get; set; }
    }
}
