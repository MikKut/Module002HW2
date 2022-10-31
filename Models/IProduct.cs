namespace ShopPurchaising.Models
{
    /// <summary>
    /// Represents a product.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Gets a unique id.
        /// </summary>
        int ID { get; }

        /// <summary>
        /// Gets a name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Checks for equality by ID.
        /// </summary>
        /// <param name="product">With wich to compare.</param>
        /// <returns>Shows the equality.</returns>
        bool Equal(IProduct product);
    }
}