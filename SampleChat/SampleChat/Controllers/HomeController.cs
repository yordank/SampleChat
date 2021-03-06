﻿using SampleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return RedirectToAction("Chat");
            return RedirectToAction("Seek");

            //return View();
        }
        public ActionResult Chat(string orientation,string time,string white,string black)
        {
            ViewBag.orientation = orientation;

            ViewBag.clockSeconds =time;

            ViewBag.white = white;

            ViewBag.black = black;

            return View();
        }

        public ActionResult ListGames()
        {

            using (var context=new ChessDbContext())
            {
                List<Results> results = context.results.OrderByDescending(x=>x.Id).ToList();


                return View(results);
            }
            
        }



        public ActionResult Seek()
        {
            return View();
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
    }
}