using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    public class OrderDetail
    {
       public int OrderID {set; get;}

       public int ProductID {set; get;}
       public int Quantity {set; get;}
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { get; set; }

    }
}