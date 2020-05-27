using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace TeduShop.Model.Models {
    [Table ("Footers")]
    public class Footer {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        [MaxLength (50)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }

    }
}