using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Miniproject_MVC_Movie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100.")]
        public int Year { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        // Viktigt: attributet ska sitta DIREKT ovanför propertyn Rating
        [ModelBinder(BinderType = typeof(Miniproject_MVC_Movie.Binders.DecimalModelBinder))]
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public decimal Rating { get; set; }

        [Display(Name = "Image file name")]
        public string? ImageName { get; set; }
    }
}
