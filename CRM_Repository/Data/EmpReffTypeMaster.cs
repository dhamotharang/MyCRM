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
    
    public partial class EmpReffTypeMaster
    {
        public EmpReffTypeMaster()
        {
            this.UserRefferenceDetails = new HashSet<UserRefferenceDetail>();
        }
    
        public int ReffTypeId { get; set; }
        public string ReffTypeName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<UserRefferenceDetail> UserRefferenceDetails { get; set; }
    }
}
