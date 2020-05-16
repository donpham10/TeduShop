using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Dynamic;
namespace TeduShop.Model.Models {
  [Table ("Orders")]
  public class Order {
    [Key]
    public int ID { set; get; }

    [Required]
    public string CustomerName { set; get; }

    [Required]
    public string CustomerAddress { set; get; }
    public string CustomerEmail { set; get; }

    [Required]
    public string CustomerMobile { set; get; }
    public string CustomerMessenger { set; get; }
    public DateTime CreateDate { set; get; }

    public string CreateBy { set; get; }

    public string PaymentMethod { set; get; }

    [Required]
    public string PaymentStatus { set; get; }
    public bool? Status { set; get; }

    [ForeignKey ("OrderID")]
    public virtual OrderDetail MenuGroup {set; get;}
  }
}