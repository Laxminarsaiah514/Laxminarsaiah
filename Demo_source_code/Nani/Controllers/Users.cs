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
    public class Users<T> : WhenCondition<T> where T : RuleContext
    {
        private static readonly System.Collections.Generic.Dictionary<string, string> UserType = new System.Collections.Generic.Dictionary<string, string>
        {
            {
                "{0C87164C-151B-4CAE-8190-E30598101EA6}",
                "India"
            },
            {
                "{876F3F39-52AE-4D31-9FE9-39D9F8A7B550}",
                "US"
            },
             {
                "{1A256F61-12EE-41CE-AB20-15A991BE6D76}",
                "Pak"
            }

        };

        public string UserName
        {
            get;
            set;
        }


        protected override bool Execute(T ruleContext)
        {
            string user;
            try
            {
                if (this.UserName != null)
                    user = Users<T>.UserType[this.UserName].ToUpper();
                else
                    user = string.Empty;
            }
            catch (System.ArgumentException ex)
            {
                Log.Error("Invalid user: " + this.UserName, ex, base.GetType());
                return false;
            }
            string usertype = string.Empty;

            if (HttpContext.Current.Request.Cookies["User"] != null)
            {
                if (HttpContext.Current.Request.Cookies["User"].Value == "1")
                    usertype = "US";
              
                else if (HttpContext.Current.Request.Cookies["User"].Value == "2")
                    usertype = "INDIA";
                else if (HttpContext.Current.Request.Cookies["User"].Value == "3")
                    usertype = "PAK";
            }

            return !string.IsNullOrEmpty(user) ? user == usertype : false;
        }

    }
}
