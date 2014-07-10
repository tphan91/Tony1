using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuctionSite.Models;
using AuctionSite.DAL;

namespace AuctionSite.Controllers
{
    public class ItemsController : Controller
    {
        private AuctionContext db = new AuctionContext();

        //
        // GET: /Items/

        public ViewResult Index()
        {
            return View(db.Items.ToList());
        }

        //
        // GET: /Items/Details/5

        public ViewResult Details(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        //
        // GET: /Items/Create

        public ActionResult Create(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        public ActionResult Search(string filter)
        {
            var items = db.Items.ToList();

            if (!string.IsNullOrEmpty(filter))
            {
                items = (from x in items
                         where x.title.ToLower().Contains(filter.ToLower())
                         orderby x.title
                         select x).ToList();
            }

            return View(items);
        }

        //
        // POST: /Items/Create

        //[HttpPost]
        //public ActionResult Create(Items items)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Items.Add(items);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");  
        //    }

        //    return View(items);
        //}

        //
        // GET: /Items/Edit/5

        /*public ActionResult Edit(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        //
        // POST: /Items/Edit/5

        [HttpPost]
        public ActionResult Edit(Items items)
        {
            if (ModelState.IsValid)
            {
                db.Entry(items).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(items);
        }

        //
        // GET: /Items/Delete/5

        public ActionResult Delete(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        //
        // POST: /Items/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Items items = db.Items.Find(id);
            db.Items.Remove(items);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }*/
        
        public string PlaceBid(string bid)
        {
            string message = HttpUtility.HtmlEncode("Item.PlaceBid, bid = " + bid);
            return message;
        }
    }
}