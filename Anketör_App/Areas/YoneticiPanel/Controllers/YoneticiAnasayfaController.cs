using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anketör_App.Areas.YoneticiPanel.Controllers
{
    public class YoneticiAnasayfaController : Controller
    {
        // GET: YoneticiPanel/YoneticiAnasayfa
        public ActionResult Index()
        {
            return View();
        }
    }
}