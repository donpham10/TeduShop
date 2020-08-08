using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISysTemConfigRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, ISysTemConfigRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}