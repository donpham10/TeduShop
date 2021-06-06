﻿using AutoMapper;
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
        private IProductCategoryServices _productCategoryService;
        //private static IErrorServices errorService;

        public ProductCategoryController(IErrorServices errorService, IProductCategoryServices productCategoryService)
            : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage getAll(HttpRequestMessage request, int page, int pageSize = 20)
        {
            int totalRow = 0;
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetAll();
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
    }
}