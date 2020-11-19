using Microsoft.AspNetCore.Http;
//using MvcMovie.Migrations;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.ViewModel
{
    public class MovieCreateViewModel
    {        
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genre")]
        public int GenreID { get; set; }
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public IFormFile Photo { get; set; }
    }
}
