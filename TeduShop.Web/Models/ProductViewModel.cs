using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }//  UncheckedKD

        public int CategoryID { set; get; }// Unchecked

        public string Image { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int ViewCount { set; get; }


        public string MetaDescription { set; get; }
        public string MetaKeywork { set; get; }
        public bool Status { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string UpdateBy { set; get; }

        public virtual ProductCategoryViewModel ProductCatagory { get; set; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { get; set; }
    }
}