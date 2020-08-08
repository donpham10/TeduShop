using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatisticRepository
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IMenuRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}