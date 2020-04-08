using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Models;


namespace Biblioteka.Repo
{
    public interface IDataRepo
    {
        List<Recepti> GetProducts();
    }
}
