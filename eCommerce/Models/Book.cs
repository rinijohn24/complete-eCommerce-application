using eCommerce.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class Book
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public BookCategory bookCategory { get; set; }
        public List<Skills_Book> Skills_Book { get; set; }
        public int PublicationId { get; set; }
        [ForeignKey("PublicationId")]
        public Publication Publication { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author
        {
            get; set;
        }
    }
    public enum BookCategory
    {
        DataScience = 1,
        Frontend,
        FullStack,
        Design,
        Cloud
    }
}
