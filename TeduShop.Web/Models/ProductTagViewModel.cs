using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual ProductViewModel Product { get; set; }

        public virtual TagViewModel Tag { get; set; }

        //public string MetaKeyword { set; get; }
        //public string MetaDescription { set; get; }
        //public bool Status { set; get; }
        //public DateTime? CreatedDate { set; get; }
        //public string CreatedBy { set; get; }
        //public DateTime? UpdateDate { set; get; }
        //public string UpdateBy { set; get; }
    }
}
