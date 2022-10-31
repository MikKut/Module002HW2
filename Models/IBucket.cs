namespace ShopPurchaising.Models
{
    /// <summary>
    /// Represents a bucket for shopping.
    /// </summary>
    internal interface IBucket
    {
        /// <summary>
        /// Gets quantity of products in the bucket.
        /// </summary>
        public int QuantityOfProducts { get; }

        /// <summary>
        /// Add product to a bucket.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>In case there is more than <see cref="QuantityOfProducts"> return false. </returns>.
        public bool AddProduct(IProduct product);
    }
}
