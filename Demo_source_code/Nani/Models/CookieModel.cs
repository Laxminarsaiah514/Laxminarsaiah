using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class CookieModel
    {
        public virtual string CookieName { get; set; }
        public virtual IList<CookieList> CookieList { get; set; }
    }
    public class CookieList
    {
        public virtual string CookieValue { get; set; }
    }
}