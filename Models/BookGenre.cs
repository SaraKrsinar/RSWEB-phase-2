﻿using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class BookGenre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}