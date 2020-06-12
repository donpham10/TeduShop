using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeduShop.Model.Models {
    [Table (" Menus")]
    public class Menu {
        [Key]

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        [MaxLength (50)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength (256)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { set; get; }

        [ForeignKey ("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }

        [MaxLength (10)]
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }

    }
}