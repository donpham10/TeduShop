using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }//  UncheckedKD
        [Required]
        public int CategoryID { set; get; }// Unchecked
        public string Image { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }

        public bool HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int ViewCount { set; get; }
        public virtual IEnumerable<PostTag> PostTag { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCatagory PostCatagory { get; set; }
    }
}
