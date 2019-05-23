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
    
    public partial class AttendanceMaster
    {
        public int AtId { get; set; }
        public int UserId { get; set; }
        public System.DateTime OnDate { get; set; }
        public Nullable<System.TimeSpan> WorkStartTime { get; set; }
        public Nullable<System.TimeSpan> WorkEndTime { get; set; }
        public Nullable<System.TimeSpan> LunchStartTime { get; set; }
        public Nullable<System.TimeSpan> LunchEndTime { get; set; }
        public Nullable<System.TimeSpan> OutSideStartTime { get; set; }
        public Nullable<System.TimeSpan> OutSideEndTime { get; set; }
        public string WorkStartIP { get; set; }
        public string WorkEndIP { get; set; }
        public string LunchStartIP { get; set; }
        public string LunchEndIP { get; set; }
        public string OutSideStartIP { get; set; }
        public string OutSideEndIP { get; set; }
        public bool IsActive { get; set; }
        public string OutSideReason { get; set; }
    
        public virtual UserMaster UserMaster { get; set; }
    }
}