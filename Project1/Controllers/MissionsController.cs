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
        {
            ListOfProducts.Add(new Product("Straw 1", "JD", "Provo", "English"));
            ListOfProducts.Add(new Product("Straw 2", "Me", "SLC", "English"));
            ListOfProducts.Add(new Product("Straw 3", "You", "Sandy", "English"));
            return View();
        }
        public ActionResult Display(int? num)
        {
            Product Send2View;
            if (num==1)
            {
                Send2View = ListOfProducts[0];
                //Send2View is option 1
            }
            else if (num==2)
            {
                Send2View = ListOfProducts[1];
                //Send2View is option 2
            }
            else
            {
                Send2View = ListOfProducts[2];
                //Send2Veiw is option 3
            }
            return View(Send2View);
        }
    }
}