using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Steven_Homework1.Models;
using Steven_Homework1.Models.ViewModel;

namespace Steven_Homework1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View("./About");
        }
        public ActionResult MoneyTemplate()
        {
            var DataPassModel = new DataPassModel
            {
                db = new VirtualDB()
            };
            return View(DataPassModel.db.DB);
        }
    }
}