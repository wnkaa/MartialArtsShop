using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.WebApp.Models.ViewModels;
using Sklep.WebApp.Models.DTO;
using System.Security.Claims;
using System.Net;
using Newtonsoft.Json;
using Sklep.WebApp.Models.Login;
using Microsoft.AspNet.Identity;
using Sklep.WebApp.Models.Identity;
using Sklep.WebApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Sklep.WebApp.Models.DTO;
using Newtonsoft.Json;
using System.Text;
namespace Sklep.WebApp.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private UserManager<AppUser> userManager;
        private RoleManager<AppUserRole> roleManager;
        private readonly string UserService = "http://localhost:3060/UserService.svc/Users/getByName/";
        // GET: Auth
        public AuthController()
        {
            AppDbContext context = new AppDbContext();

            UserStore<AppUser> userStore = new UserStore<AppUser>(context);
            userManager = new UserManager<AppUser>(userStore);

            RoleStore<AppUserRole> roleStore = new RoleStore<AppUserRole>(context);
            roleManager = new RoleManager<AppUserRole>(roleStore);
        }
        [HttpGet]
        public ActionResult LogIn(string retunUrl)
        {
            var model = new Login();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Login model)
        {


            if (ModelState.IsValid)
            {
                AppUser user = userManager.Find(model.UserName, model.Password);
                if (user != null)
                {
                    var authentication = HttpContext.GetOwinContext().Authentication;
                    authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                    ClaimsIdentity identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationProperties props = new AuthenticationProperties();
                    props.IsPersistent = model.RememberMe;
                    authentication.SignIn(props, identity);

                    return RedirectToAction("Index", "Home");
                }
            }                                                 
            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }
        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Register()
        {
            Register model = new Register();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser { UserName = model.UserName, Email = model.Email};
                
                IdentityResult result = userManager.Create(user, model.Password);
                if (result.Succeeded)
                {

                    AddressDTO adres = new AddressDTO { Street = model.Street, Phone = model.Phone };
                    UserDTO usr = new UserDTO{Username=model.UserName,Address=adres,Roles="User",Email=model.Email,Pasword="Itakzmienilemmodel"};
                    var request = HttpWebRequest.Create("http://localhost:3060/AddressService.svc/Addresses/add");
                    var dataToSend = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(adres));
                    request.ContentType = "application/json";
                    request.ContentLength = dataToSend.Length;
                    request.Method = "POST";
                    request.GetRequestStream().Write(dataToSend, 0, dataToSend.Length);
                    
                    var request2 = HttpWebRequest.Create("http://localhost:3060/UserService.svc/Users/add");
                    var dataToSend2 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(usr));
                    request2.ContentType = "application/json";
                    request2.ContentLength = dataToSend2.Length;
                    request2.Method = "POST";
                    request2.GetRequestStream().Write(dataToSend2, 0, dataToSend2.Length);

                    userManager.AddToRole(user.Id, "User");
                    var auth = HttpContext.GetOwinContext().Authentication;
                    ClaimsIdentity identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    auth.SignIn(identity);
                    return RedirectToAction("Index", "Home");
                }
                else {
                    ModelState.AddModelError("UserName", "Error while creating the user!");
                }
            }
            return View(model);
        }

    }
}