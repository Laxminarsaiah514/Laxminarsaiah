using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class Notification
    {
        internal readonly DateTime NotificationDate;

        public virtual Guid id { get; set; }
        public virtual int MaxMNotification { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Image Icon { get; set; }
        public virtual IList<Items> Notificationitems { get; set; }
    }
    public class Items
    {
        public virtual Guid id { get; set; }
        public virtual string NotificationText { get; set; }
        public virtual DateTime NotificationDate { get; set; }
    }
}