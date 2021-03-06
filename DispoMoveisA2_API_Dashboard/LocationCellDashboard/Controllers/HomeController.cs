﻿using LocationCellAPI.Models;
using LocationCellDashboard.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocationCellDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<LocationSensor> locationSensor = LocationSensorDAO.InitializeGetLocationSensor();

            return View(locationSensor);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult ListLocationSensor()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}