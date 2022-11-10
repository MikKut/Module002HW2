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
        /// <value>
        /// A unique id.
        /// </value>
        int ID { get; }

        /// <summary>
        /// Gets a name.
        /// </summary>
        /// <value>
        /// Product name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets a description.
        /// </summary>
        /// <value>
        /// A description of the product.
        /// </value>
        string Description { get; }

        /// <summary>
        /// Checks for equality by ID.
        /// </summary>
        /// <param name="product">With wich to compare.</param>
        /// <returns>Shows the equality.</returns>
        bool Equal(IProduct product);
    }
}