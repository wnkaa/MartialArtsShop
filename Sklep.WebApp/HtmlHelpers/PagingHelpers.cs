using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using Sklep.WebApp.Models.ViewModels;
namespace Sklep.WebApp.HtmlHelpers
{
    public static  class PagingHelpers
    {
        // extension method for htmlhelper class
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= pagingInfo.totalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a"); // tworzenie znacznika a
                tag.MergeAttribute("href", pageUrl(i)); // atrybut href
                tag.InnerHtml = i.ToString(); // wartosc do powyzszego atrybutu
                if (i == pagingInfo.currentPage)
                    tag.AddCssClass("selectedPage"); // jesli znajdujemy sie na tej samej stronie
                sb.Append(tag.ToString());
            }
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}