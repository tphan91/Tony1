using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auction.Models;
using AuctionSite.DAL;
using System.Data.OleDb;
using System.Xml;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using AuctionSite.Models;

namespace Auction.Controllers
{
    public class HomeController : Controller
    {
        AuctionContext db = new AuctionContext();

        public ActionResult Index()
        {
            var item = db.Items.ToList();

            return View(item);
        }

        public ActionResult Create(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        public ActionResult Items(int id)
        {
            Items items = db.Items.Find(id);
            return View(items);
        }

        public ActionResult Faq()
        {
            return View();
        }
    }
}
