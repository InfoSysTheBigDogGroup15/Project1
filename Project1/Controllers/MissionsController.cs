using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        
        static public List<Product> ListOfProducts = new List<Product>();
        
        public ActionResult Index()
        {   if (ListOfProducts.Count == 0)
            {
                ListOfProducts.Add(new Product("Blockchain straw", "JD", "Provo", "English"));
                ListOfProducts.Add(new Product("Bio straw", "Me", "SLC", "English"));
                ListOfProducts.Add(new Product("Plasma Straw", "You", "Sandy", "English"));
            }
            return View();
        }
        public ActionResult Display(int? num)
        {
            int Send2View=0;
            if (num==1)
            {
                Send2View = 0;
                //Send2View is option 
            }
            else if (num==2)
            {
                Send2View = 1;
                //Send2View is option 2
            }
            else if (ListOfProducts.Count<=0)
            {
                ListOfProducts.Add(new Product("Blockchain straw", "JD", "Provo", "English"));
                ListOfProducts.Add(new Product("Bio straw", "Me", "SLC", "English"));
                ListOfProducts.Add(new Product("Plasma Straw", "You", "Sandy", "English"));

            }
            else
            {

            }
            return View(ListOfProducts);
        }
    }
}