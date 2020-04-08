using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Biblioteka.Models;
using Biblioteka.Services;


namespace WebApiExample.Api.Controllers
{
    // The products controller provides operations for products
    public class ProductsController : ApiController
    {
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }


        [Route("api/recepti")]
        [HttpGet]
        public IEnumerable<Recepti> Get()
        {
            return service.GetProducts();
        }
    }
}