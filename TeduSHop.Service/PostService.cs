using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduSHop.Service
{
    public interface IPostService
    {
        void Add(Post Post);

        void Update(Post Post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int Page, int PageSize, out int TotalRow);

        Post GetById(int Id);

        IEnumerable<Post> GetAllByByTagPaging(string Tag,int Page, int PageSize, out int TotalRow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;

        }
        public void Add(Post Post)
        {
            _postRepository.Add(Post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllByByTagPaging( string Tag,int Page, int PageSize, out int TotalRow)
        {
            //TODO: Select all post by Tag
            return _postRepository.GetMultiPaging(x => x.Status, out TotalRow,Page,PageSize);
        }

        public IEnumerable<Post> GetAllPaging(int Page, int PageSize, out int TotalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out TotalRow, Page, PageSize);
        }

        public Post GetById(int Id)
        {
            return _postRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post Post)
        {
            _postRepository.Update(Post);
        }
    }
}