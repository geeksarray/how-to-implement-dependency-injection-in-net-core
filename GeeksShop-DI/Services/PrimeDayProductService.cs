using GeeksShop_DI.Models;
using GeeksShop_DI.Services.Interfaces;

namespace GeeksShop_DI.Services
{
    public class PrimeDayProductService : IProduct
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 4,
                    Name = "Galaxy A15 Mobile",
                    ListPrice = 400 - PrimeDayDiscount
                },
                new Product()
                {
                    Id = 5,
                    Name = "Laptop",
                    ListPrice = 500 - PrimeDayDiscount
                },
                new Product()
                {
                    Id = 3,
                    Name = "Pen drive",
                    ListPrice = 300 - PrimeDayDiscount
                }
            };
            return products;
        }

        public int PrimeDayDiscount
        {
            get { return 10; }
        }
    }
}
