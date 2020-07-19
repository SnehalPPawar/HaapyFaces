using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

using HappyFacesAPI.DBEntities;
//sing HappyFacesAPI.Models;

namespace HappyFacesAPI.Repository
{
    public class ProductRepository : HappyFacesRepository<HappyFacesAPI.DBEntities.Product>, IProductRepository
    {
        HappyFacesContext context;
        public ProductRepository(HappyFacesContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetCheapProducts()
        {
            return context.Products.OrderBy(x => x.Price).ToList();
        }

        public IEnumerable<Product> GetTopProducts()
        {
            return context.Products.OrderByDescending(x => x.Price).ToList();
        }


    }
}