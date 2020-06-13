using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SystempConfigs")]
    public class SystemConfig
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Code { set; get; }
        [MaxLength(50)]
        public string ValueString { set; get; }
        public int? ValueInt { set; get; }
    }
}
