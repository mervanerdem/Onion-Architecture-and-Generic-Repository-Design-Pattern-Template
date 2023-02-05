
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ECommerceAPI.Application.Repositories;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/controllers")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;

        readonly private IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async void Get() 
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {id = Guid.NewGuid(), Name = "Product 1", CreateDate= DateTime.UtcNow, Price = 100 , Stock = 10},
                new() {id = Guid.NewGuid(), Name = "Product 2", CreateDate= DateTime.UtcNow, Price = 200 , Stock = 20},
                new() {id = Guid.NewGuid(), Name = "Product 3", CreateDate= DateTime.UtcNow, Price = 300 , Stock = 30},

            });
            await _productWriteRepository.SaveAsync();
        }


    }
}
