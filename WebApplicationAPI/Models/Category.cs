using WebApplicationAPI.Models;

namespace WebApplicationAPI.Model
{
    public class Category
    {

        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public virtual List<Product> Products { get; set; }
    }
}
