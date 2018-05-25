using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
    public static class MyHtml
    {
        public static MvcHtmlString Label2(this HtmlHelper html, string expression)
        {
            return MvcHtmlString.Create("<p>2222</p>");
        }
    }
}