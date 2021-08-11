using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProdcts()
        {
            var products = await _context.Products.ToListAsync();
            return  Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProdct(int id)
        {
            return  await _context.Products.FindAsync(id);
        }
    }
}