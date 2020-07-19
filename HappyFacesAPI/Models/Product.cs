using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyFacesAPI._Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}