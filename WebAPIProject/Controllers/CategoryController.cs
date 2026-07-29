using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class CategoryController
    {
        private ProjectContext context;

        CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        public void AddCategory(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }
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


        public Category GetCategory(int id)
        {
            var category = context.categories.FirstOrDefault(c => c.CategoryId == id);
            return category;
        }
        public List<Category> GetAllCategories()
        {
            return context.categories.ToList();
        }
        public List<Category> GetByName(string name)
        {
            return context.categories.Where(c => c.CategoryName.Contains(name)).ToList();
        }

    }
}
