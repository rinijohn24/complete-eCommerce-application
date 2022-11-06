using eCommerce.Data;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Skills_Book> Skills_Books { get; set; }
    }
}
