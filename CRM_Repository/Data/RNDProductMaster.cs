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
    
    public partial class RNDProductMaster
    {
        public RNDProductMaster()
        {
            this.RNDSupplierMasters = new HashSet<RNDSupplierMaster>();
        }
    
        public int RNDProductId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> EmailSpeechId { get; set; }
        public Nullable<int> SMSSpeechId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifyBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public bool IsActive { get; set; }
        public string RMPhotos { get; set; }
        public string MPPhotos { get; set; }
        public string FMPhotos { get; set; }
        public string Videoes { get; set; }
        public string EmailSubject { get; set; }
        public string EmailSpeech { get; set; }
        public string SMSSpeech { get; set; }
        public string ChatSpeech { get; set; }
    
        public virtual EmailSpeechMaster EmailSpeechMaster { get; set; }
        public virtual SubCategoryMaster SubCategoryMaster { get; set; }
        public virtual SMSSpeechMaster SMSSpeechMaster { get; set; }
        public virtual ICollection<RNDSupplierMaster> RNDSupplierMasters { get; set; }
    }
}
