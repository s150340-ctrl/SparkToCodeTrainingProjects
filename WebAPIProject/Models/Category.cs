using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAPIProject.Models
{
    public class Category
    {
        [Key]
        [JsonIgnore]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryDescription { get; set; }
        //1-M
        [JsonIgnore]
        public List<Product>? Products { get; set; }
    }
}
