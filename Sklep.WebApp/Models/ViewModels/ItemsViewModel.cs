using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sklep.WebApp.Models.DTO;
namespace Sklep.WebApp.Models.ViewModels
{
    public class ItemsViewModel
    {
        public List<ItemDTO> listItem { get; set; }
        public PagingInfo pagingInfo { get; set; }
        public string category { get; set; }
    }
}