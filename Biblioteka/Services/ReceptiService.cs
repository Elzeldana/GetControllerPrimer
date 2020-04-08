using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Biblioteka.Repo;
using Biblioteka.Models;
namespace Biblioteka.Services
{
    public class ProductService : IProductService
    {
        private readonly IDataRepo repo;
        public ProductService(IDataRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Recepti> GetProducts()
        {
            return repo.GetProducts();
        }

    }
}