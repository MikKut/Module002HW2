using ShopPurchaising.Models;
using ShopPurchaising.UI;

namespace ShopPurchaising
{
    /// <summary>
    /// Contains entry point to a program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point to a program.
        /// </summary>
        public static void Main()
        {
            int productIndex = 0;
            IProduct[] products = new Product[]
            {
    new Product(productIndex++, "Apple", "Yellow Apple"),
    new Product(productIndex++, "Apple", "Red Apple"),
    new Product(productIndex++, "Pineaple", "Yellow pineaple"),
    new Product(productIndex++, "Guapple", "Green Apple"),
    new Product(productIndex++, "Wood Apple", "Limonia acidissima"),
    new Product(productIndex++, "Rose Apple", "Tastes like a cross between pears and roses."),
    new Product(productIndex++, "Custard Apple", "Pawpaw fruit"),
    new Product(productIndex++, "Cashew Apple", "Actually a nut"),
    new Product(productIndex++, "Velvet apple", "mabolo or tálang"),
    new Product(productIndex++, "Star apple", "Caimito fruit"),
    new Product(productIndex++, "Iceapple", "Apple from wine palm"),
            };

            var orderMaker = new OrderMaker(products);
            orderMaker.MakeOrder();
        }
    }
}
