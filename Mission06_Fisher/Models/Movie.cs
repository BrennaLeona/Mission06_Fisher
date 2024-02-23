﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Fisher.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [ForeignKey("Category")] //Connects to other class
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Please provide a title for the movie")]
        public string Title { get; set; } //Required
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year cannot be before 1888.")] //Limit year choices
        public int Year { get; set; } //Required
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Please indicate whether the movie is edited or not")]
        public bool Edited { get; set; } //Required
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Please indicate whether the movie is copied to Plex or not")]
        public bool CopiedToPlex { get; set; } //Required
        [StringLength(25)] //Up to 25 characters
        public string? Notes { get; set; }
    }
}
