using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Book
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public BookCategory bookCategory { get; set; }
    }
    public enum BookCategory
    {
        DataScience = 1,
        Frontend,
        FullStack
    }
}
