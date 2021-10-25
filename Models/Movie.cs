using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_mvc_movies.Models
{
    public enum Genres
    {
        Comedy, Drama, Horror, Romance
    }

    /// <summary>
    /// Return the values of the Movie title, date, genre and
    /// price and assigns the values to these variables
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; } = Genres.Drama;

        [Range(1.99, 20.00), Required]
        public decimal Price { get; set; }
    }
}
