using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Client.Models
{
    public class Movie
    {
        public int Id { get; set; }
        // AddingNewEventArgs some condition for character length 
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]
        [StringLength(20)]
        public required string Genre { get; set; }
        [Range(1, 100)]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}