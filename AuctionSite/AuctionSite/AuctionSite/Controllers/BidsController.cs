using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auction.Models;
using AuctionSite.Models;
using AuctionSite.DAL;

namespace AuctionSite.Controllers
{
    public class BidsController : Controller
    {
        private AuctionContext db = new AuctionContext();

        //
        // GET: /Bids/

        public ViewResult Index()
        {
            
            return View(db.Items.ToList());
        }

        //
        // GET: /Bids/Details/5
        
        public ViewResult Create(int id)
        {
            var items = db.Items.Find(id);
            return View(items);
        }

        //
        // GET: /Bids/Create

        public ViewResult Details(int id)
        {
            Items item = db.Items.Find(id);
           // Bids bid = new Bids();
            //bid.Item = item;
            return View(item);
        }

        //
        // POST: /Bids/Create

        //[HttpPost]
        //public ActionResult Create(Bids bids)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Bids.Add(bids);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");  
        //    }

        //    return View(bids);
        //}

        //
        // GET: /Bids/Edit/5

       /* public ActionResult Edit(int id)
        {
            Bids bids = db.Bids.Find(id);
            return View(bids);
        }

        //
        // POST: /Bids/Edit/5

        [HttpPost]
        public ActionResult Edit(Bids bids)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bids).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bids);
        }

        //
        // GET: /Bids/Delete/5

        public ActionResult Delete(int id)
        {
            Bids bids = db.Bids.Find(id);
            return View(bids);
        }

        //
        // POST: /Bids/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Bids bids = db.Bids.Find(id);
            db.Bids.Remove(bids);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }*/
    }
}