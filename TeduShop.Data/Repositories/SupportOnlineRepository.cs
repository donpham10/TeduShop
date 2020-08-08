using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, IMenuRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}