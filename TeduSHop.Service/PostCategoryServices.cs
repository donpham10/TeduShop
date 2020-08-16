using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduSHop.Service
{
    public interface IPostCategoryServices
    {
        void Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int ParentID);

        PostCategory GetById(int Id);

        void SaveChange();
    }

    public class PostCategoryServices : IPostCategoryServices

    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public PostCategoryServices(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return  _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int ParentID)
        {
            return _postCategoryRepository.GetMulti(x=>x.Status && x.ParentID == ParentID);
        }

        public PostCategory GetById(int Id)
        {
            return _postCategoryRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}