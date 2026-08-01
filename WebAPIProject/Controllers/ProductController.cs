using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private ProjectContext context;

        ProductController(ProjectContext _context)
        {
            context = _context;
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();
            return Ok(p.ProductId);
        }
        [HttpDelete("RemoveProduct")]
        public IActionResult RemoveProduct(int id)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                context.products.Remove(product);
                context.SaveChanges();
                return Ok("Product removed successfully.");
            }
            else
            {
                return NotFound("Product not found.");
            }
        }
        [HttpPatch("UpdateProductPrice")]
        public IActionResult UpdateProductPrice(int id, double price)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.ProductPrice = price;
                context.SaveChanges();
                return Ok("Product price updated successfully.");
            }
            return NotFound("Product not found.");
        }
        [HttpPatch("UpdateProductName")]
        public IActionResult UpdateProductName(int id, string newName)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.ProductName = newName;
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        [HttpPut("UpdateProduct")]//alters whole thing
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.ProductName = updatedProduct.ProductName;
                product.ProductPrice = updatedProduct.ProductPrice;
                product.CategoryId = updatedProduct.CategoryId;
                product.ProductDescription = updatedProduct.ProductDescription;
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            return Ok(product);
        }
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            return Ok(context.products.ToList());
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            return Ok(context.products.Where(p => p.ProductName.Contains(name)).ToList());
        }
    }
}
