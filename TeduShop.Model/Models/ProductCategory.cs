using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]

    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool HomeFlag { set; get; }

        public virtual IEnumerable<Product> Product { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }

    }
}