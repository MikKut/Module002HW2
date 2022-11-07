namespace ShopPurchaising.Models
{
    /// <inheritdoc />
    public class Product : IProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="id">Product ID.</param>.
        /// <param name="name">Product name.</param>.
        /// <param name="desctiption">Product description.</param>.
        public Product(int id, string name, string desctiption)
        {
            ID = id;
            Name = name;
            Description = desctiption;
        }

        /// <inheritdoc />
        public int ID { get; private set; }

        /// <inheritdoc />
        public string Name { get; private set; }

        /// <inheritdoc />
        public string Description { get; private set; }

        /// <inheritdoc />
        public bool Equal(IProduct product)
        {
            if (ID == product.ID)
            {
                return true;
            }

            return false;
        }
    }
}
