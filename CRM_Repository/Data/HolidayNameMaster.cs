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
    
    public partial class HolidayNameMaster
    {
        public HolidayNameMaster()
        {
            this.HolidayMasters = new HashSet<HolidayMaster>();
        }
    
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<HolidayMaster> HolidayMasters { get; set; }
    }
}
