using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPurchaising.Models
{
    internal interface IBucket
    {
        public int QuantityOfProducts { get; }
        public bool AddProduct(IProduct product);
        public bool DeleteProduct(IProduct product);
    }
}
