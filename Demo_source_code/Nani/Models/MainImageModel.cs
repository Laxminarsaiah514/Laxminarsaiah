using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nani.Models
{
    public class MainImageModel
    {
        public virtual Guid id { get; set; }
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
        public virtual IList<ImageItem> ImageItems { get; set; }
      
        public virtual IList<ImageFinalItem> ImageFinalItems { get; set; }
        public virtual string LinkTitle { get; set; }

    }
    public class ImageItem
    {
        public virtual Guid id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Image Image { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Link Link { get; set; }
    }
 
    public class ImageFinalItem
    {
        public virtual Guid id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string SubTitle { get; set; }
        public virtual string SubDescription { get; set; }
        public virtual string SubButtonTitle { get; set; }
        public virtual IList<ImageFinalSubItem> ImageFinalSubItems { get; set; }
    }
    public class ImageFinalSubItem
    {
        public virtual Guid id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Glass.Mapper.Sc.Fields.Image SubImage { get; set; }
    }
}