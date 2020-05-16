using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostCatagories")]
    public class PostCatagory
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }//   Unchecked
        [Required]
        public string Alias { set; get; }//    Unchecked
        public string Description { set; get; }
        public int ParentID { set; get; }
        public string Image { set; get; }
        public int DisplayOrder { set; get; }
        public bool HomeFlag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
        
}
