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
    
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string Type_ { get; set; }
        public Nullable<System.DateTime> FeedbackDate { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public Nullable<int> OrderID { get; set; }
    
        public virtual User User { get; set; }
    }
}
