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
    
    public partial class PageOperationMaster
    {
        public PageOperationMaster()
        {
            this.GroupPermissionMappings = new HashSet<GroupPermissionMapping>();
        }
    
        public int OperationId { get; set; }
        public int MenuId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsAdd { get; set; }
        public Nullable<bool> IsEdit { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> GroupId { get; set; }
    
        public virtual ICollection<GroupPermissionMapping> GroupPermissionMappings { get; set; }
    }
}
