using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Publication
    {
        [Key ] public int Id { get; set; }
        [Display(Name= "Publication Name")]
        public string Name { get; set; }
        [Display(Name="Description")]
        public string Description { get; set; }
        [Display(Name="Logo")]
        public string Image { get; set; }
        public List<Book> Books { get; set; }

    }
}
