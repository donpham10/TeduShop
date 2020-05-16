using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
   public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [Key]
        public int TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
