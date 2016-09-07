using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class Links
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Image Image { get; set; }
    }
}