using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuctionWithDb.Models;
using AuctionWithDb.ViewModel;
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
        public ActionResult PlaceAuction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlaceAuction(Auction model)
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
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register model)
        {
            using (var db = new AuctionEntities())
            {
                    var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Username = model.UserName,
                    Password = model.Password,
                    Email = model.EmailAddress,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    CreatedBy = model.EmailAddress,
                };
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            return View();
        }
    }
}