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
    public class SystempConfig
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { set; get; }
        public string ValueString { set; get; }
        public int ValueInt { set; get; }
    }
}
