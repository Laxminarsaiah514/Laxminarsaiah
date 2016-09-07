using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using Nani.Models;


namespace Nani.Controllers
{
    public class IndiaController : Controller
    {
        public ActionResult HeaderContent()
        {
            HeaderModel headermodel = new HeaderModel();

            var context = new SitecoreContext();

            headermodel = context.GetItem<HeaderModel>(RenderingContext.Current.Rendering.DataSource);

            return View(headermodel);
        }
        public ActionResult NotificationAction()
        {
            Notification notification = new Notification();

            var context = new SitecoreContext();

            notification = context.GetItem<Notification>(RenderingContext.Current.Rendering.DataSource);
            HttpCookie myCookie = null;
            if (Request.Cookies["Notifications"] == null)
            {
                myCookie = new HttpCookie("Notifications");
                if (notification.Notificationitems != null)
                {
                    int count = notification.Notificationitems.ToList().Count - 1;
                    myCookie.Values["count"] = count.ToString();
                    myCookie.Values[notification.Notificationitems[0].id.ToString()] = "read";
                    Response.Cookies.Add(myCookie);
                }

            }

            return View(notification);
        }
        // GET: India

        public void SessionManager(string userType)
        {
            HttpCookie myCookie = null;

            if (Request.Cookies["User"] == null)
            {
                myCookie = new HttpCookie("User");
            }
            else
            {
                myCookie = Request.Cookies["User"];
            }


            if (userType == "US")

            {
                myCookie.Value = "1";
            }

            if (userType == "India")
            {
                myCookie.Value = "2";
            }
            if (userType == "Pak")
            {
                myCookie.Value = "4";
            }


            Response.Cookies.Add(myCookie);

            myCookie.Expires = DateTime.Today.AddMonths(12);
        }


        public void CookieExists(string cookieName)
        {
            HttpCookie cookie = null;
            if (Request.Cookies[cookieName] == null)
            {
                cookie = new HttpCookie(cookieName);
                cookie.Value = "1";
                Response.Cookies.Add(cookie);
                cookie.Expires = DateTime.Today.AddMonths(6);
            }
        }

        public void CookieWithValue(string cookieName, string cookieValue)
        {
            HttpCookie cookie = null;
            if (Request.Cookies[cookieName] == null)
            {
                cookie = new HttpCookie(cookieName);
            }
            else
            {
                cookie = Request.Cookies[cookieName];
            }
            cookie.Value = cookieValue;
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Today.AddMonths(12);
        }


        public int CountLogic(string guid, int totalCount)
        {
            HttpCookie countCookie = Request.Cookies["Notifications"];
            if (!countCookie.Values.AllKeys.Contains(guid))
            {
                countCookie.Values[guid] = "read";
            }
            int val = totalCount - countCookie.Values.Count + 1;
            countCookie.Expires = DateTime.Today.AddMonths(6);
            countCookie.Values["count"] = val.ToString();
            Response.Cookies.Add(countCookie);
            return val;
        }


        public ActionResult MainContent()
        {

            MainImageModel imagemodel = new MainImageModel();
            var context = new SitecoreContext();
            imagemodel = context.GetItem<MainImageModel>(RenderingContext.Current.Rendering.DataSource);
            return View(imagemodel);
        }
        public ActionResult LinkContentAction()
        {

            var dataSource = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            return View(dataSource);
        }
        public ActionResult Footer()
        {

            var dataSource = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            return View(dataSource);
        }
        public ActionResult Home()
        {

            CookieModel cookie = new CookieModel();
            var context = new SitecoreContext();
            cookie = context.GetItem<CookieModel>(RenderingContext.Current.Rendering.DataSource);
            return View(cookie);
        }
        public ActionResult Carousel()
        {

            CarouselModel carousel = new CarouselModel();
            var context = new SitecoreContext();
            carousel = context.GetItem<CarouselModel>(RenderingContext.Current.Rendering.DataSource);
            return View(carousel);
        }

    }
}