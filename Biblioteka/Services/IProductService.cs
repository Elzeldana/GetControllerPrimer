using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Models;

namespace Biblioteka.Services
{
   public interface IProductService
    {
        IEnumerable<Recepti> GetProducts();
    }
}
