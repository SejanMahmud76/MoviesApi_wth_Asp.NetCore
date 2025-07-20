using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi_wth_Asp.NetCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [Range(1,180)]
        public decimal Price {  get; set; }

        //Navigation property
        [ValidateNever]
        public Genre? Genre { get; set; }   

        //Foreign Key property
        public int GenreId { get; set; }
        public DateOnly ReleseDate { get; set; }
    }
}
