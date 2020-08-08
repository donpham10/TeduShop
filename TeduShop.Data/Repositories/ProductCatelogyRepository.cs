using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string Alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string Alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == Alias);
        }
    }
}