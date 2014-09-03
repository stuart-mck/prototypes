using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using to_lib;

namespace autotransmission.Models
{
    public class SessionState
    {
        public Article CurrentArticle { get 
        {
            if (HttpContext.Current.Session["currentArticle"] != null)
                return (Article)HttpContext.Current.Session["currentArticle"];
            return null;
        } 
            set 
            {
                HttpContext.Current.Session["currentArticle"] = value;
            } 
        }
    }
}