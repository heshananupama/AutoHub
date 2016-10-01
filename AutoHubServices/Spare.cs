//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoHubServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spare
    {
        public Spare()
        {
            this.CartItems = new HashSet<CartItem>();
            this.Categories = new HashSet<Category>();
            this.VehicleModels = new HashSet<VehicleModel>();
        }
    
        public int SpareId { get; set; }
        public string PartNumber { get; set; }
        public Nullable<int> Quantity { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> Warranty { get; set; }
        public string Description { get; set; }
        public byte[] SpareImage { get; set; }
        public string RetailerUsername { get; set; }
    
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual Retailer Retailer { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}