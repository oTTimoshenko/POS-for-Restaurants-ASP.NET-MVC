using AutoMapper;
using POSforRestaurants.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POSforRestaurants.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IAdminService admin;
        IMapper mapper;

        public AdminController(IAdminService admin, IMapper mapper)
        {
            this.admin = admin;
            this.mapper = mapper;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}