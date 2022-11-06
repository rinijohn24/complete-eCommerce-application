using eCommerce.Models;

namespace eCommerce.Data
{
    public class Skills_Book
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int SkillId { get; set; }
        public Skills Skill { get; set; }
    }
}
