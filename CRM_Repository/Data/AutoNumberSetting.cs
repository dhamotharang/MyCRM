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
    
    public partial class AutoNumberSetting
    {
        public int SettingId { get; set; }
        public string InvoiceType { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int Length { get; set; }
        public int StartNo { get; set; }
        public int Addition { get; set; }
        public bool IsActive { get; set; }
    }
}