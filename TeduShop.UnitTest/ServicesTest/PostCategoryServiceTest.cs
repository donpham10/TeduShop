using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduSHop.Service;

namespace TeduShop.UnitTest.ServicesTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryServices _categoryservice;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryservice = new PostCategoryServices(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1, Name="dm1",Status=true },
                new PostCategory() {ID=2, Name="dm1",Status=true },
                new PostCategory() {ID=3, Name="dm1",Status=true },
            };
        }

        [TestMethod]
        public void PostCategory_service_GetAll()
        {
            //setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            // call action

            var result = _categoryservice.GetAll() as List<PostCategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void PostCategory_service_Create()
        {
            PostCategory pCategory = new PostCategory();
            pCategory.Name = "test";
            pCategory.Alias = "test";
            pCategory.Status = true;

            _mockRepository.Setup(m => m.Add(pCategory))
                .Returns((PostCategory p) => { p.ID = 1; return p; });
            var result = _categoryservice.Add(pCategory);

            Assert.IsNotNull(result);

            Assert.AreEqual(5, result.ID);
        }
    }
}