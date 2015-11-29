﻿using System;
using System.Web;
using System.Web.Mvc;
using MirrorProject.Models;
using Newtonsoft.Json;
using WebGrease.Css.ImageAssemblyAnalysis.LogModel;

namespace MirrorProject.Controllers
{
    public class HomeController : Controller
    {

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ServiceSingleton.GetInstance();
            RssSingleton.GetInstance();
            return View();
        }

        public ActionResult WeatherUpdate()
        {
            return Json(JsonConvert.SerializeObject(ServiceSingleton.GetInstance().GetWeatherReport()),JsonRequestBehavior.AllowGet);
        }

        public ActionResult RssUpdate()
        {
            return Json(JsonConvert.SerializeObject(RssSingleton.GetInstance().GetRssItems()), JsonRequestBehavior.AllowGet);
        }

    }
}