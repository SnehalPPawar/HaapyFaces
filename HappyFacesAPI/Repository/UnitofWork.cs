using HappyFacesAPI.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyFacesAPI.Repository
{
    public class UnitofWork : IUnitofWork
    {
        HappyFacesContext _context;

        public UnitofWork()
        {
            _context = new DBEntities.HappyFacesContext();
            Category = new CategoryRepository(_context);
            Product = new ProductRepository(_context);
        }

        public UnitofWork(HappyFacesContext context)
        {
            this._context = context;
        }

       
        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}