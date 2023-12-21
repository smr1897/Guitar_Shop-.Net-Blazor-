using GuitarShop.Server.Models;
using GuitarShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace GuitarShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly GuitarShopDbContext _DataContext;

        public ProductController(GuitarShopDbContext DataContext) 
        {
            _DataContext = DataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _DataContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("accousticguitars")]
        public async Task<ActionResult<Product>> GetAccousticGuitarProducts()
        {
            try
            {
                var products = await _DataContext.Products.Where(p => p.CategoryId == 1 && p.SubCategoryId == 1).ToListAsync();

                if(products == null || !products.Any())
                {
                    return NotFound(); //Return 404 if no matching product was found
                }

                return Ok(products);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("electricguitars")]
        public async Task<ActionResult<Product>> GetElectricGuitarProducts()
        {
            try
            {
                var products = await _DataContext.Products.Where(p => p.CategoryId == 1 && p.SubCategoryId == 2).ToListAsync();

                if(products == null || !products.Any())
                {
                    return NotFound(); //Return 404 if no matching product is found
                }

                return Ok(products);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "Initial Server Error");
            }
        }

        [HttpGet("bass")]
        public async Task<ActionResult<Product>> GetBassGuitarProducts()
        {
            try
            {
                var products = await _DataContext.Products.Where(p => p.CategoryId == 1 && p.SubCategoryId == 3).ToListAsync();

                if(products == null || !products.Any())
                {
                    return NotFound();
                }
                return Ok(products);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "Initial Server Error"); 
            }
        }

        [HttpGet("piano&keyboards")]
        public async Task<ActionResult<Product>> GetPianoAndKeyboardProducts()
        {
            try
            {
                var products = await _DataContext.Products.Where(p => p.CategoryId == 2 && p.SubCategoryId == 1).ToListAsync();

                if (products == null || !products.Any())
                {
                    return NotFound();
                }
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Initial Server Error");
            }
        }

        [HttpGet("users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _DataContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetSingleProduct(int id)
        {
            var product = await _DataContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            if(product == null) 
            {
                return NotFound("sorry , no can't find the product with the id");
            }
            return Ok(product);
        }
    }
}
