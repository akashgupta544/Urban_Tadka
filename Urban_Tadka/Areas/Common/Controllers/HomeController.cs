using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Urban_BOL;
using System.Data.Entity;
using System.Data;

namespace Urban_Tadka.Areas.Common.Controllers
{
    public class HomeController : Controller
    {
        // GET: Common/Home
        UTEntitiesContext db = new UTEntitiesContext();
       
        public ActionResult Index()
        {

            List<Item_Info> items= new List<Item_Info>();
            items = db.Item_Info.ToList();
            
            return View(items);
        }
        public ActionResult Buffet_Menu()
        {

            List<Item_Info> items = new List<Item_Info>();
            items = db.Item_Info.ToList();
            return View(items);
        }
        public ActionResult locate()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            List<Item_Info> items = new List<Item_Info>();
            items = db.Item_Info.ToList();
            return View(items);
        }
        [HttpPost]
        public ActionResult Login(List<Item_Info> items)
        {
            foreach (Item_Info item in items)
            {

                Item_Info it = db.Item_Info.Find(item.Item_ID);
                it.Is_Buffet = item.Is_Buffet;
            }
            db.SaveChanges();
            return RedirectToAction("Buffet_Menu"); 
           
      }
        public ActionResult cater()
        {
            List<Item_Info> items = new List<Item_Info>();
            items = db.Item_Info.ToList();
            return View(items);

        }
       
       

            
            
            
        }
    }

