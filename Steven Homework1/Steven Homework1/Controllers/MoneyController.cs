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
            return View();
        }
        public ActionResult MoneyTemplate()
        {
            var DataPassModel = new DataPassModel { rd = new RandomData() };
            return View(DataPassModel);
        }
    }
}