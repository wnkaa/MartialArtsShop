using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.WebApp.Models.ViewModels;
using Sklep.WebApp.Models.DTO;
using System.Net;
namespace Sklep.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly string UserService = "http://localhost:3060/UserService.svc/Users/";
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Registration reg)
        {
            if (ModelState.IsValid)
            {
                UserDTO usr;
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadString(UserService + "getByName/" + reg.FirstName);
                }
            }
        }
    }
}