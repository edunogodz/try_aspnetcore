using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CharacterSheetApp.Models.Character();
            model.Name = "Hux";
            return View(model);
        }

    }
}