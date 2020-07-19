using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HappyFacesAPI.Repository;
using HappyFacesAPI._Models;
namespace HappyFacesAPI.Controllers
{
    public class HappyFacesController : ApiController
    {
        private readonly UnitofWork _UnitofWork;
        public HappyFacesController()
        {
            _UnitofWork = new UnitofWork();
        }
        public HappyFacesController(UnitofWork unitofWork)
        {
            _UnitofWork = unitofWork;
        }

        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage();
        }
        public HttpResponseMessage CreateProduct(ProductModel objPrpduct)
        {
            _UnitofWork.Product.Add(new DBEntities.Product()
            {
                ProductID = objPrpduct.ProductID,
                ProductName = objPrpduct.ProductName,
                Price = objPrpduct.Price
            });

            _UnitofWork.Complete();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
