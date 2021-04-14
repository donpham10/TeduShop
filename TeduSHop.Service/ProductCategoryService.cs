using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduSHop.Service
{
    public interface IProductCategoryServices
    {
        ProductCategory Add(ProductCategory ProductCategory);

        void Update(ProductCategory ProductCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllByParentID(int ParentID);

        ProductCategory GetById(int Id);

        void SaveChange();
    }

    public class ProductCategoryServices : IProductCategoryServices

    {
        private IProductCategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryServices(IProductCategoryRepository ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._ProductCategoryRepository = ProductCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory ProductCategory)
        {
            return _ProductCategoryRepository.Add(ProductCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _ProductCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _ProductCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByParentID(int ParentID)
        {
            return _ProductCategoryRepository.GetMulti(x => x.HomeFlag && x.ParentID == ParentID);
        }

        public ProductCategory GetById(int Id)
        {
            return _ProductCategoryRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _ProductCategoryRepository.Update(ProductCategory);
        }
    }
}
