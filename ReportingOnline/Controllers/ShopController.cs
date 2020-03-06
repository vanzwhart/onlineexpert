using ReportingOnline.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportingOnline.Controllers
{
   
    public class ShopController : Controller
    {
       
        // GET: Shop
        
        public ActionResult Index()
        {
            //var userid = _context.Users.FirstOrDefault(a => a.UserName == User.Identity.Name).Id;
            //IList<MsOnlineShop> shop = _context.OnlineShop.Where(x => x.UserID == userid).ToList();
            return View();
        }
    }
}