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
    
    public partial class SupplierAddressMaster
    {
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public int SupplierId { get; set; }
        public string PinCode { get; set; }
        public string Fax { get; set; }
    
        public virtual CityMaster CityMaster { get; set; }
        public virtual SupplierMaster SupplierMaster { get; set; }
    }
}
