using System.Collections.Generic;
using System.Xml;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public XmlElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]
        public string Desription { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public bool ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
        public virtual IEnumerable<ProductTag> ProductTag { set; get; }

    }
}