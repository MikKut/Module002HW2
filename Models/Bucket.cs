using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPurchaising.Models
{
    internal class Bucket : IBucket
    {
        private const int BusketSize = 10;
        private IProduct[] products; // array :(
        public int QuantityOfProducts { get; private set; }
        public Bucket()
        {
            products = new IProduct[BusketSize];
        }
        public bool AddProduct(IProduct product)
        {
            if (QuantityOfProducts == BusketSize)
            {
                return false;
            }
            products[QuantityOfProducts++] = product;
            return true;
        }

        public bool DeleteProduct(IProduct product)
        {
            if (QuantityOfProducts > 0)
            {
                return false;
            }

            var takenProducts = Array.FindAll(products, x => !x.Equal(product)); // find all products that is not the product
            if (takenProducts.Length == QuantityOfProducts)
            {
                return false;
            }
            else
            {
                QuantityOfProducts--;
                Array.Clear(products);
                for(int i = 0; i < takenProducts.Length; i++)
                {
                    products[i] = takenProducts[i];
                }
            }

        }
    }
}
