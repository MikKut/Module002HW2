﻿namespace ShopPurchaising.UI
{
    using ShopPurchaising.Models;

    /// <summary>
    /// Class for making orders.
    /// </summary>
    internal class OrderMaker
    {
        private static int indexOfBucket = 0;
        private readonly IProduct[] products;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMaker"/> class.
        /// </summary>
        /// <param name="products">All products for the bucket. Does not accept nulls.</param>
        public OrderMaker(IProduct[] products)
        {
            this.products = products;
        }

        /// <summary>
        /// Make order session.
        /// </summary>
        public void MakeOrder()
        {
            BucketCreator bucketCreator = new BucketCreator(this.products);
            var bucket = bucketCreator.FormBucket();
            if (bucket.QuantityOfProducts != 0)
            {
                Console.WriteLine($"Your order number {++indexOfBucket} was made");
            }
            else
            {
                Console.WriteLine("Your bucket is empty");
            }
        }
    }
}
