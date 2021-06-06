using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        
        public int ID { set; get; }

       
        public string Name { get; set; }

        
        public string Alias { get; set; }

        
        public string Description { set; get; }
        public int? ParentID { set; get; }

        public int? DisplayOrder { set; get; }

       
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
    }
}