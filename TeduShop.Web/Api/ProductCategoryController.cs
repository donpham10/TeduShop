using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Web.Infrastrcture.Core;
using TeduShop.Web.Infrastrcture.Extensions;
using TeduShop.Web.Models;
using TeduSHop.Service;

namespace TeduShop.Web.Api
{
    [RoutePrefix("Api/ProductCategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryServices _productCategoryService;
        //private static IErrorServices errorService;

        public ProductCategoryController(IErrorServices errorService, IProductCategoryServices productCategoryService)
            : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage getAll(HttpRequestMessage request,string filter, int page, int pageSize = 20)
        {
            int totalRow = 0;
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetAll(filter);
                totalRow = model.Count();
                var query = model.OrderByDescending(x => x.CreatedDate).Skip(page * pageSize).Take(pageSize);

                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(query);

                var paginationSet = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = responseData,
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };

                var response = request.CreateResponse(HttpStatusCode.OK, paginationSet);
                return response;
            });
        }

        [Route("getbyid/{id:int}")]
        [HttpGet]
        public HttpResponseMessage GetById(HttpRequestMessage request,int ID)
        {
            
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetById(ID);
                var responseData = Mapper.Map<ProductCategory,ProductCategoryViewModel>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("getallParentId")]
        [HttpGet]
        public HttpResponseMessage getAll(HttpRequestMessage request)
        {
           
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetAll();
              
                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }

        [Route("create")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Create (HttpRequestMessage request,ProductCategoryViewModel ProductCatelogyVm )
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var newProductCategory = new ProductCategory();
                    newProductCategory.CreatedDate = DateTime.Now;
                    newProductCategory.UpdateProductCategory(ProductCatelogyVm);
                    _productCategoryService.Add(newProductCategory);
                    _productCategoryService.SaveChange();
                    var responseData = Mapper.Map<ProductCategory, ProductCategoryViewModel>(newProductCategory);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                   
                }
                return response;
            });

        }
        [Route("update")]
        [HttpPut]
        [AllowAnonymous]
        public HttpResponseMessage Update(HttpRequestMessage request, ProductCategoryViewModel ProductCatelogyVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var dbProductCategory = _productCategoryService.GetById(ProductCatelogyVm.ID);
                    dbProductCategory.UpdateProductCategory(ProductCatelogyVm);
                    dbProductCategory.CreatedDate = DateTime.Now;
                    _productCategoryService.Update(dbProductCategory);
                    _productCategoryService.SaveChange();
                    var responseData = Mapper.Map<ProductCategory, ProductCategoryViewModel>(dbProductCategory);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);

                }
                return response;
            });

        }
    }
}