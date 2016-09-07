using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class CarouselModel
    {
        public virtual IList<CarouselItem> CarouselItems { get; set; }
    }
    public class CarouselItem
    {
        public virtual Glass.Mapper.Sc.Fields.Image CarouselImage { get; set; }

        public virtual string CarouselTitle { get; set; }
        public virtual string Description { get; set; }
    }
}