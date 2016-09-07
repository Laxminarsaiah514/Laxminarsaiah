using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Nani.Controllers
{
    public class CookieExists<T> : WhenCondition<T>  where T : RuleContext
    {
        public string CookieName { get; set; }

        protected override bool Execute(T ruleContext)
        {
            if (String.IsNullOrEmpty(CookieName))
                return false;

            if (HttpContext.Current.Request.Cookies[CookieName] == null)
                return false;

            return true;
        }
    }
}