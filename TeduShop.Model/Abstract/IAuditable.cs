// dam bao thuc hien nhieu thao tac tren cung mot giao dich
using System;
namespace TeduShop.Model.Abstract {
    public interface IAuditable {
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        bool Status { set; get; }
    }

}