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
    
    public partial class UserEducationDetail
    {
        public int EducationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> QualificationId { get; set; }
        public string InstituteName { get; set; }
        public Nullable<int> CityId { get; set; }
        public string PinCode { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> Todate { get; set; }
        public string EduDescription { get; set; }
    
        public virtual QualificationsMaster QualificationsMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}