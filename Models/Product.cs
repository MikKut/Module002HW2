using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPurchaising.Models
{
    /// <inheritdoc />
    public class Product : IProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="id">ID:<see cref="ID">.</param>.
        /// <param name="name">Name:<see cref="Name">.</param>.
        /// <param name="desctiption">Description: <see cref="Description">.</param>.
        public Product(int id, string name, string desctiption)
        {
            this.ID = id;
            this.Name = name;
            this.Description = desctiption;
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
            if (this.ID == product.ID)
            {
                return true;
            }

            return false;
        }
    }
}
