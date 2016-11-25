using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Model.Entities;
using Data.Model.ViewModels;
using Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IAspNetUserService _userService;

        public HomeController(IAspNetUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            var db = new Entities();
            Mapper.Initialize(cfg=>cfg.CreateMap<AspNetUser, AspNetUserViewModel>());


            var data = db.AspNetUsers.ProjectTo<AspNetUserViewModel>().ToList() ;
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