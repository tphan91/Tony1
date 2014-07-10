using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AuctionSite.Models
{
    public class BaseClass
    {
        public decimal currentBid { get; set; } //the current highest bid

        public string highestBidder { get; set; }

        public int increment { get; set; }

        [DisplayName("Bid")]
        public decimal bidAmount { get; set; } //amount the user wants to bid

        public decimal startBid { get; set; }

    }
}