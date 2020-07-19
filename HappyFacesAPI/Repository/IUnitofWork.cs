using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyFacesAPI.Repository;

namespace HappyFacesAPI.Repository
{
    public interface IUnitofWork : IDisposable
    {
         ICategoryRepository Category { get;  }
         IProductRepository Product { get; }

        int Complete();
    }
}
