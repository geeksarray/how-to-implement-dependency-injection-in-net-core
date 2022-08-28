using GeeksShop_DI.Models;
using GeeksShop_DI.Services.Interfaces;

namespace GeeksShop_DI.Services
{
    public class ProductService : IProduct
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Galaxy A13 Mobile",
                    ListPrice = 100
                },
                new Product()
                {
                    Id = 2,
                    Name = "Air Pods",
                    ListPrice = 200
                },
                new Product()
                {
                    Id = 3,
                    Name = "Pen drive",
                    ListPrice = 300
                }
            };
            return products;
        }
    }
}
