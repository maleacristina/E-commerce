﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [StringLength(255)]
        public string PublishingHouse { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public int AvailableQuantity { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public decimal Price { get; set; }

     
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}