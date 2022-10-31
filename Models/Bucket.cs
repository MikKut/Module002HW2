namespace ShopPurchaising.Models
{
    /// <summary>
    /// Represents a bucket for shopping.
    /// </summary>
    internal class Bucket : IBucket
    {
        /// <summary>
        /// Shows bucket size.
        /// </summary>
        public const int BusketSize = 10;
        private IProduct[] products;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket"/> class.
        /// Creates default empty bucket with 10 slots.
        /// </summary>
        public Bucket()
        {
            this.products = new IProduct[BusketSize];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket"/> class.
        /// </summary>
        /// <param name="products">Products of the bucket.</param>
        /// <param name="quantityOfProducts">Quantity of products.</param>
        public Bucket(IProduct[] products, int quantityOfProducts)
        {
            if (products.Length > 10)
            {
                throw new Exception("Too much _products in the bucket");
            }

            this.products = products;
            this.QuantityOfProducts = quantityOfProducts;
        }

        /// <summary>
        /// Gets quantity of products in the bucket.
        /// </summary>
        public int QuantityOfProducts { get; private set; }

        /// <summary>
        /// Add product to a bucket.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>In case there is more than <see cref="QuantityOfProducts"> return false. </returns>.
        public bool AddProduct(IProduct product)
        {
            if (this.QuantityOfProducts == BusketSize)
            {
                return false;
            }

            this.products[this.QuantityOfProducts++] = product;
            return true;
        }
    }
}
