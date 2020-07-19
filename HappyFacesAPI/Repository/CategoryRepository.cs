using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//using HappyFacesAPI.Models;
using HappyFacesAPI.DBEntities;

namespace HappyFacesAPI.Repository
{
    public class CategoryRepository : HappyFacesRepository<Category>, ICategoryRepository
    {
        HappyFacesContext context;
        public CategoryRepository(HappyFacesContext context) : base(context)
        {
        }

        public IEnumerable<Category> GetCheapProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetTopProducts()
        {
            throw new NotImplementedException();
        }
    }
}