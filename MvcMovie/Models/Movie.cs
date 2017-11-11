using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required,Display(Name = "Title",Prompt = "Title"),DataType(DataType.Text)]
        public string Title { get; set; }
        [Required, Display(Name = "Release Date", Prompt = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required, Display(Name = "Genre", Prompt = "Genre"), DataType(DataType.Text),StringLength(maximumLength:60)]
        public string Genre { get; set; }
        [Required, Display(Name = "Price", Prompt = "Price"), DataType(DataType.Currency)]
        public decimal Price { get; set; }


    }
}
