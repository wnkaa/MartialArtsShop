using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.WebApp.Models.DTO;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text;
namespace Sklep.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly string orderService = "http://localhost:3060/OrderService.svc/Orders/";
        private readonly string cartService = "http://localhost:3060/CartService.svc/Carts/";
        private readonly string CartItemService = "http://localhost:3060/CartItemService.svc/CartItems/";
        private readonly string UserService = "http://localhost:3060/UserService.svc/Users/";
        // GET: Order
        public ActionResult CheckOut()
        {
            CartDTO cart = (CartDTO)Session["Cart"];
            UserDTO user = new UserDTO();

            using(WebClient wc = new WebClient()){
                string data;
                data =wc.DownloadString(UserService+"1");
                user = JsonConvert.DeserializeObject<UserDTO>(data);
            }
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            OrderDTO order = new OrderDTO() { 
            Cart=cart,
            OrderDate=DateTime.ParseExact(date,"yyyy-MM-dd",null),
            User=user,
            UserID= user.UserID,
            CartID=cart.CartID
            };
               
                
                foreach (var item in cart.CartItems)
                {
                    var req1 = HttpWebRequest.Create(CartItemService + "Add");
                    var dataToSend1 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(item));
                    req1.ContentType = "application/json";
                    req1.ContentLength = dataToSend1.Length;
                    req1.Method = "POST";
                    req1.GetRequestStream().Write(dataToSend1, 0, dataToSend1.Length);
                }
                var req2 = HttpWebRequest.Create(cartService + "Add");
                var dataToSend = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(cart));
                req2.ContentType = "application/json";
                req2.ContentLength = dataToSend.Length;
                req2.Method = "POST";
                req2.GetRequestStream().Write(dataToSend, 0, dataToSend.Length);

                var req3 = HttpWebRequest.Create(orderService + "Add");
                var dataToSend2 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order));
                req3.ContentType = "application/json";
                req3.ContentLength = dataToSend2.Length;
                req3.Method = "POST";
                req3.GetRequestStream().Write(dataToSend2, 0, dataToSend2.Length);
            return View();
        }
    }
}