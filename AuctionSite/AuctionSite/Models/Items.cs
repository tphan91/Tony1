using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuctionSite.Models;
using System.ComponentModel;

namespace AuctionSite.Models
{
    public class Items : BaseClass
    {

        public int ItemsID { get; set; }

        [DisplayName("Valuation")]
        public decimal valuation { get; set; }

        [DisplayName("Artist")]
        public string artist { get; set; }

        [DisplayName("Title")]
        public string title { get; set; }

        [DisplayName("Condition")]
        public string condition { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        public virtual ICollection<Bids> Bids { get; set; }
    }
}