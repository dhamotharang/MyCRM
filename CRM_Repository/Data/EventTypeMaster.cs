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
    
    public partial class EventTypeMaster
    {
        public EventTypeMaster()
        {
            this.EventMasters = new HashSet<EventMaster>();
        }
    
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<EventMaster> EventMasters { get; set; }
    }
}
