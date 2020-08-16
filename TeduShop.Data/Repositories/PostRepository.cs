using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTagPaging(string Tag, int Page, int PageSize, out int TotalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTagPaging(string Tag, int PageIndex, int PageSize, out int TotalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == Tag
                        select p;
            TotalRow = query.Count();
            query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            return query;
        }
    }
}