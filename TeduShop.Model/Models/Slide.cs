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
    [Table("Slides")]
    public class Slide : Auditable
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; } 
        public string Description { set; get; }
        [Required]
        public string Image { set; get; }
        [Required]
        public string URL { set; get; }
        public int DisplayOder { set; get; }



    }
}
