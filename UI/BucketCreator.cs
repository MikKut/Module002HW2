using ShopPurchaising.Models;

namespace ShopPurchaising.UI
{
    /// <summary>
    /// Class for creating buckets.
    /// </summary>
    internal class BucketCreator
    {
        private const string PositiveAnswer = "Yes";
        private const string NegativeAnswer = "No";
        private IProduct[] _products;

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketCreator"/> class.
        /// </summary>
        /// <param name="products">Array of all _products in system.</param>
        public BucketCreator(IProduct[] products)
        {
            _products = products;
        }

        /// <summary>
        /// Forms a bucket.
        /// </summary>
        /// <returns>Bucket.</returns>
        public IBucket FormBucket()
        {
            IBucket bucket = new Bucket();
            for (int i = 0; i < _products.Length; i++)
            {
                if (!AskAboutPuttingTheProductIntoTheBucketAndPutIt(ref bucket, _products[i]))
                {
                    Console.WriteLine("You cannot add more _products in the bucket: Bucket is full!");
                    break;
                }
            }

            return bucket;
        }

        /// <summary>
        /// Ask the user about putting product the product into the bucket.
        /// </summary>
        /// <param name="bucket"> Busket where to put the product. </param>
        /// <param name="product"> Product that can be putted. </param>
        /// <returns>There is more slots of the bucket to fill. </returns>
        private static bool AskAboutPuttingTheProductIntoTheBucketAndPutIt(ref IBucket bucket, IProduct product)
        {
            bool isCorrectAnswer = true;
            while (isCorrectAnswer)
            {
                Console.WriteLine($"Do you want to add a \n\"{product.Name}\":\n{product.Description} to your bucket?(Type \"{PositiveAnswer}\"\\\"{NegativeAnswer}\")");
                string? response = Console.ReadLine();
                switch (response)
                {
                    case PositiveAnswer:
                        if (!bucket.AddProduct(product))
                        {
                            return false;
                        }

                        isCorrectAnswer = false;
                        break;
                    case NegativeAnswer:
                        isCorrectAnswer = false;
                        break;
                    default:
                        isCorrectAnswer = true;
                        Console.WriteLine($"Your answer and neither \"{PositiveAnswer}\" nor \"{NegativeAnswer}\". Try again.");
                        break;
                }
            }

            return true;
        }
    }
}
