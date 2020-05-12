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
         public int ID {set; get;}
 [Required]
       public string Name {set; get;}
 [Required]
       public string Alias {set; get;}
       public int CategoryID {set;get;}
        
       public string Image  {set; get;}
       
       public decimal Price {set; get;}
       public int? PromotionPrice {set; get;}
       public int? Warranty {set;get;}
       public string Desription {set; get;}
       public string Conten{set; get;}
       public bool? HomeFlag {set; get;}
       public bool? HotFlag{set; get;}
       public bool ViewCount{set; get;}
       [ForeignKey("CategoryID")]

       public virtual ProductCategory ProductCategory{set; get;}
        
    }
}