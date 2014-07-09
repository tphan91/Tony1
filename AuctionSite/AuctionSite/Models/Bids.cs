using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuctionSite.Models;
using System.ComponentModel.DataAnnotations;

namespace AuctionSite.Models
{
    public class Bids : BaseClass
    {
        [Key]
        public int BidsID { get; set; }

        //[ForeignKey("Items")]
        public int ItemsID { get; set; }

        public DateTime timeStamp { get; set; }

        public Items Item { get; set; }

        public decimal currentorstartingBid
        {
            get
            {
                return bidAmount > 0 ? currentBid : startBid;
            }
        }    

        public decimal nextBid
        {
            get
            {
                //if the amount bid is greater than 0, then 
                return bidAmount > 0 ? currentBid + increment : startBid;
            }
        }
    }
}


