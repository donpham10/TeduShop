﻿using System;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }//   Unchecked
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }//    Unchecked
        [MaxLength(256)]
        public string Description { set; get; }
        public int? ParentID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }
        public int? DisplayOrder { set; get; }
        public bool HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
        
}
