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
    
    public partial class WorkProfileMaster
    {
        public int WorkProfileId { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.TimeSpan> WorkTime { get; set; }
        public string WorkDay { get; set; }
        public string WorkCycle { get; set; }
        public string WorkDuration { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public string WorkRule { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> WorkDate { get; set; }
    
        public virtual DepartmentMaster DepartmentMaster { get; set; }
    }
}
