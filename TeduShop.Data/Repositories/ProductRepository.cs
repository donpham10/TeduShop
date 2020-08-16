using System;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByAlias(string Alias);
        IEnumerable<Product> GetAllTagByID(string Tag, int PageIndex, int PageSize, out int TotalCount);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetAllTagByID(string Tag, int PageIndex, int PageSize, out int TotalCount)
        {
            var query = from p in DbContext.Products
                        join pt in DbContext.ProductTags
                        on p.ID equals pt.ProductID
                        where pt.TagID == Tag
                        select p;
            TotalCount = query.Count();
            query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            return query;
        }

        public IEnumerable<Product> GetByAlias(string Alias)
        {
            return this.DbContext.Products.Where(x => x.Alias == Alias);
        }
    }
}