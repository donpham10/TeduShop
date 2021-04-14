using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }//   Unchecked

        public string Alias { set; get; }//    Unchecked

        public string Description { set; get; }

        public int? ParentID { set; get; }

        public string Image { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        public string MetaKeyword { set; get; }


        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string UpdateBy { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}