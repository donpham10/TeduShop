using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objectRepository;
        IUnitOfWork unitOfwork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objectRepository = new PostCategoryRepository(dbFactory);
            unitOfwork = new UnitOfWork(dbFactory);

        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test category";
            category.HomeFlag = true;
            var result = objectRepository.Add(category);
            unitOfwork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ID,4);

        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var result = objectRepository.GetAll().ToList();
            Assert.AreEqual(result.Count, 4);

        }
    }
}