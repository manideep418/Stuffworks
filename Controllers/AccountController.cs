using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StuffWorks.Models;
using System.Web.Security;
using StuffWorks.Code;
using System.Data;

namespace StuffWorks.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View("AccountIndex");
        }

        [HttpGet]
        //GET: StufferRegistration
        public ActionResult RegisterStuffer()
        {
            RegisterStuffer stuffer = new RegisterStuffer();
            
            stuffer.Services = GetServices();
            return View(stuffer);
        }

        private static List<SelectListItem> GetServices()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            DataTable dt = null;
            
            return items;
        }

        [HttpPost]
        public void Register(Register model)
        {
            if (ModelState.IsValid)
            {
               
            }
        }

        [HttpPost]
        public void RegisterStuffer(RegisterStuffer model)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            List<SelectListItem> items = new List<SelectListItem>();
            items = GetServices();
            if (ModelState.IsValid)
            {
               
            }

        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                if(!model.rememberme)
                {
                    
                }
                else if(model.rememberme)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        // 1- login module
        // 2 - register module


        [AllowAnonymous]
        [HttpPost]
        public JsonResult IsEmailIDExists(string EmailID)
        {
            if (ModelState.IsValid)
            {
                if (EmailID != null)
                {
                    
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                return Json(false);
            }

        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult IsEmailIDExistsRegister(string EmailID)
        {
            if (ModelState.IsValid)
            {
                if (EmailID != null)
                {
                    
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                return Json(false);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}