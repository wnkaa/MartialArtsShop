using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.WebApp.Models.DTO;
using Sklep.WebApp.Models.ViewModels;
using System.Net;
using Newtonsoft.Json;
namespace Sklep.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly string itemsService = "http://localhost:3060/ItemService.svc/Items/";
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Items(string category,int page=1)
        {
            if (category != null)
            {
                List<ItemDTO> items = new List<ItemDTO>();
                using (WebClient wc = new WebClient())
                {
                    string dane;
                    dane = wc.DownloadString(itemsService + "getByCategory/" + category);
                    items = JsonConvert.DeserializeObject<List<ItemDTO>>(dane);
                }
                int id = 12;

                items.Add(new ItemDTO() { ItemID=id++});
                items.Add(new ItemDTO() { ItemID = id++ });
                items.Add(new ItemDTO() { ItemID = id++ });
                items.Add(new ItemDTO() { ItemID = id++ });
                items.Add(new ItemDTO() { ItemID = id++ });
                items.Add(new ItemDTO() { ItemID = id++ });
                items.Add(new ItemDTO() { ItemID = id++ });
                ItemsViewModel ivm = new ItemsViewModel();
                ivm.category = category;
                ivm.pagingInfo = new PagingInfo { itemsPerPage = 6, totalItems = items.Count , currentPage=page};
                ivm.listItem = items.OrderBy(i => i.ItemID).Skip(6 * (page - 1)).Take(6).ToList();
               return View(ivm);
            }

            return View();
        }
    }
}