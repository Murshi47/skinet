using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
     [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        
      public ProductsController(IProductRepository repo)
      {
            _repo = repo;
            
      }
      
      [HttpGet]

       public async Task<ActionResult<List<Product>>>Getproducts()
       {
         var products = await _repo.GetProductsAsync();

         return Ok(products);
       } 

       [HttpGet("{id}")]

       public async Task<ActionResult<Product>> Getproducts(int id)
       {
         return await _repo.GetProductByIdAsync(id);
       }
    }
}    


