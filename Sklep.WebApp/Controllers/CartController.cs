using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Sklep.WebApp.Models.DTO;
using Newtonsoft.Json;
namespace Sklep.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly string itemsService = "http://localhost:3060/ItemService.svc/Items/";
        // GET: Cart
        private CartDTO getCart()
        {
            CartDTO cart = (CartDTO)Session["Cart"];
            if (cart == null)
            {
                cart = new CartDTO();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public ViewResult Index()
        {
            return View(getCart());
        }
        public RedirectResult addToCart(int ItemID, string returnUrl){
            ItemDTO item = new ItemDTO();
            using (WebClient wc = new WebClient())
            {
                string dane;
                dane =wc.DownloadString(itemsService + ItemID);
                item = JsonConvert.DeserializeObject<ItemDTO>(dane);
            }
            if (item != null)
            {
                getCart().addItem(item, 1);
            }
            return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
           // return RedirectToAction("Items","Home", new { returnUrl });
         }
        public RedirectToRouteResult removeFromCart(int ItemID, string returnUrl)
        {
            ItemDTO item = new ItemDTO();
            using (WebClient wc = new WebClient())
            {
                string dane;
                dane = wc.DownloadString(itemsService + ItemID);
                item = JsonConvert.DeserializeObject<ItemDTO>(dane);
            }
            if (item != null)
            {
                getCart().removeItem(item);
            }
            return RedirectToAction("Index");
        }
    }
}