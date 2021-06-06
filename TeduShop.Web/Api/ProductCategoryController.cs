using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Web.Infrastrcture.Core;
using TeduShop.Web.Models;
using TeduSHop.Service;

namespace TeduShop.Web.Api
{
    [RoutePrefix("Api/ProductCategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        IProductCategoryServices _productCategoryService;
        //private static IErrorServices errorService;

        public ProductCategoryController(IErrorServices errorService, IProductCategoryServices productCategoryService) 
            : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }
        [Route("getall")]
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
    }
}
