using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Web.Infrastrcture.Core;
using TeduShop.Web.Models;
using TeduShop.Web.Infrastrcture.Extensions;
using TeduSHop.Service;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryServices _postCategoryService;

        public HttpResponseMessage PostCatelogyViewModel { get; private set; }

        public PostCategoryController(IErrorServices errorService, IPostCategoryServices postCategoryservice)
            : base(errorService)
        {
            this._postCategoryService = postCategoryservice;
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage response = null;

                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     PostCategory newPostCategory = new PostCategory();
                     newPostCategory.UpdatePostCategory(postCategoryViewModel);
                     var category = _postCategoryService.Add(newPostCategory);
                     _postCategoryService.SaveChange();

                     response = request.CreateResponse(HttpStatusCode.Created, category);
                 }
                 return response;
             });
        }

        [Route("getall")]
        public HttpResponseMessage get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll();

                var listPostCategoryViewModel = Mapper.Map<List<PostCategoryViewModel>>(listCategory);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.Created, listCategory);

                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var tempPostCategory = _postCategoryService.GetById(postCategoryViewModel.ID);
                    tempPostCategory.UpdatePostCategory(postCategoryViewModel);
                    _postCategoryService.Update(tempPostCategory);
                    _postCategoryService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}