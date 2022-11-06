﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Publications
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}
