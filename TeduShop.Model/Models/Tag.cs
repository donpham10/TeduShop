using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public int ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public virtual IEnumerable<ProductTag> ProductTag { set; get; }
        public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}
