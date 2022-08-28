using GeeksShop_DI.Models;
using GeeksShop_DI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GeeksShop_DI.Services;

namespace GeeksShop_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProduct _product;
        public ProductController(IProduct product)
        {
            this._product = product;
        }



        [HttpGet]
        [Route("GetProducts")]
        public List<Product> GetProducts()
        {
            return this._product.GetProducts();
        }
    }
}
