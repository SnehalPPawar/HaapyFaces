using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyFacesAPI.DBEntities;

namespace HappyFacesAPI.Repository
{
    public interface ICategoryRepository : IHappyFacesRepository<Category>
    {
        IEnumerable<Category> GetTopProducts();

        IEnumerable<Category> GetCheapProducts();
    }
}
