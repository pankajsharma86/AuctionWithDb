//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuctionWithDb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auction
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> Endtime { get; set; }
        public Nullable<double> StartPrice { get; set; }
        public Nullable<double> CurrentPrice { get; set; }
    }
}
