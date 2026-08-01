using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;

        CategoryController(ProjectContext _context)
        {
            context = _context;
        }
        [HttpPost("AddCategory")]

        public void AddCategory(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }
        [HttpDelete("RemoveCategory")]
        public void RemoveCategory(int id)
        {
            var category = context.categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                context.categories.Remove(category);
                context.SaveChanges();
            }
            else { }
        }

        [HttpGet("GetCategory")]
        public Category GetCategory(int id)
        {
            var category = context.categories.FirstOrDefault(c => c.CategoryId == id);
            return category;
        }
        [HttpGet("GetAllCategories")]
        public List<Category> GetAllCategories()
        {
            return context.categories.ToList();
        }
        [HttpGet("GetByName")]
        public List<Category> GetByName(string name)
        {
            return context.categories.Where(c => c.CategoryName.Contains(name)).ToList();
        }

    }
}
