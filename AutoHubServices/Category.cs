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
    
    public partial class Category
    {
        public Category()
        {
            this.Spares = new HashSet<Spare>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string AdminUsername { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Spare> Spares { get; set; }
    }
}
