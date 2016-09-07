using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class HeaderModel
    {
        public virtual Guid id { get; set; }
        public virtual string AppTitle { get; set; }
        public virtual IList<HeaderItems> MainHeaderItems { get; set; }
       

        public virtual Glass.Mapper.Sc.Fields.Image Image { get; set; }
    }
    public class HeaderItems
    {
        public virtual Guid id { get; set; }
        public virtual string HeaderTitle { get; set; }
        public virtual IList<HeaderSubItems> HeaderSubItems { get; set; }
    }
    public class HeaderSubItems
    {
        public virtual Guid id { get; set; }
        public virtual string Title { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Link Link { get; set;}
    }
}