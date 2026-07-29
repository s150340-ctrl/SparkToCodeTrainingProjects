using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        //1-M
        public List<Product> Products { get; set; }
    }
}
