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
    
    public partial class ProductPackingDetail
    {
        public int PackingId { get; set; }
        public Nullable<int> CatalogId { get; set; }
        public string Description { get; set; }
        public string NetWeight { get; set; }
        public string GrossWeight { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> CBM { get; set; }
        public string Dimension { get; set; }
        public Nullable<decimal> DealerPrice { get; set; }
        public Nullable<decimal> FinalPrice { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> PackingTypeId { get; set; }
        public Nullable<int> PlugShapeId { get; set; }
        public Nullable<int> PhaseId { get; set; }
        public Nullable<int> VoltageId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public string Power { get; set; }
    
        public virtual FrequencyMaster FrequencyMaster { get; set; }
        public virtual PhaseMaster PhaseMaster { get; set; }
        public virtual PlugShapeMaster PlugShapeMaster { get; set; }
        public virtual ProductCatalogMaster ProductCatalogMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual VoltageMaster VoltageMaster { get; set; }
    }
}