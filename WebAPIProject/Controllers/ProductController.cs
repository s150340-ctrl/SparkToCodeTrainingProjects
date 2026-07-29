using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class ProductController
    {
        private ProjectContext context;

        ProductController(ProjectContext _context)
        {
            context = _context;
        }

        public void AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();
        }
        public void RemoveProduct(int id)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                context.products.Remove(product);
                context.SaveChanges();
            }
            else { }
        }
        public void UpdateProductPrice(int id, double price)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.ProductPrice = price;
                context.SaveChanges();
            }
        }
        public void UpdateProductName(int id, string newName)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.ProductName = newName;
                context.SaveChanges();
            }
        }
        public Product GetProduct(int id)
        {
            var product = context.products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }
        public List<Product> GetAllProducts()
        {
            return context.products.ToList();
        }
        public List<Product> GetByName(string name)
        {
            return context.products.Where(p => p.ProductName.Contains(name)).ToList();
        }
    }
}
