using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Author
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Book> Books { get; set; }
    }
}
