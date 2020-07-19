using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyFacesAPI.DBEntities;

namespace HappyFacesAPI.Repository
{
    public interface IProductRepository : IHappyFacesRepository<Product>
    {
        IEnumerable<Product> GetTopProducts();

        IEnumerable<Product> GetCheapProducts();

    }
}
