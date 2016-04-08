using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuctionWithDb.Models;
using System.Web.Security;

namespace AuctionWithDb.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Auction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Auction([Bind(Exclude = "CurrentPrice")]Auction model)
        {
            using (var db = new AuctionEntities())
            {
                var bid = new Auction
                {
                    Category = model.Category,
                    Title = model.Title,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    StartTime = model.StartTime,
                    Endtime = model.Endtime,
                    StartPrice = model.StartPrice,
                    CurrentPrice = model.CurrentPrice,
                };

                db.Auctions.Add(bid);
                db.SaveChanges();
            }
                return View();
        }




    }
}