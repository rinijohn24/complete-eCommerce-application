using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Author
    {
        [Key] public int Id { get; set; }
        [Display(Name="Author Name")]
        public string Name { get; set; }
        [Display(Name="About Author")]
        public string Description { get; set; }
        [Display(Name="Profile Picture")]
        public string Image { get; set; }
        public List<Book> Books { get; set; }
    }
}
