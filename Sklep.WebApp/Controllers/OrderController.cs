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
        private readonly string orderService = "http://localhost:3060/OrderService.svc/Orders/Add";
        private readonly string cartService = "http://localhost:3060/CartService.svc/Carts/";
        private readonly string CartItemService = "http://localhost:3060/CartItemService.svc/CartItems/";
        private readonly string UserService = "http://localhost:3060/UserService.svc/Users/";
        // GET: Order
        public ActionResult CheckOut()
        {
             CartDTO cart = (CartDTO)Session["Cart"];
             if (cart == null)
                 cart = new CartDTO();

            UserDTO user = new UserDTO();

            using(WebClient wc = new WebClient()){
                string data;
                data =wc.DownloadString(UserService+"3");
                user = JsonConvert.DeserializeObject<UserDTO>(data);
            }


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
            var dataToSend2 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(cart));
            req2.ContentType = "application/json";
            req2.ContentLength = dataToSend2.Length;
            req2.Method = "POST";
            req2.GetRequestStream().Write(dataToSend2, 0, dataToSend2.Length);
           
            int cartid =  0;
            CartDTO cartdto = new CartDTO();
            using (WebClient wc = new WebClient())
            {
                
                var data = (wc.DownloadString("http://localhost:3060/CartService.svc/Carts/last"));
                cartid = Convert.ToInt32(data);
                var kart = (wc.DownloadString("http://localhost:3060/CartService.svc/Carts/"+cartid));
                cartdto= JsonConvert.DeserializeObject<CartDTO>(kart);
            }
            
            
            //var sprawdz = JsonConvert.SerializeObject(order);
            //var dataToSend2 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order));
            //var dataJson = JsonConvert.SerializeObject(order);
            //why the heck it isnt working QQ
            OrderDTO order= new OrderDTO { Cart= cart,OrderDate=DateTime.Now,User=user};
            var requestOrder = HttpWebRequest.Create(orderService);
            var dataOrder = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order));
            requestOrder.ContentType = "application/json";
            requestOrder.ContentLength = dataOrder.Length;
            requestOrder.Method = "POST";
            requestOrder.GetRequestStream().Write(dataOrder, 0, dataOrder.Length);

            // still dunno why it isnt working QQ
            //OrderDTO ord = new OrderDTO { OrderID = 1, OrderDate = DateTime.Now, CartID=cartid,Cart=cartdto,User=user,UserID=user.UserID };
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(orderService);
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    var json = JsonConvert.SerializeObject(ord);

            //    streamWriter.Write(json);
            //    streamWriter.Flush();
            //}

            return View();
        }
    }
}