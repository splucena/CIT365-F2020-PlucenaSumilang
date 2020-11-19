using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        [Required]
        public string Description { get; set; }

        private bool Sum(int a, int b, int c)
        {
            bool v = !((a <= 0 || b <= 0) && (a <= 0 || c <= 0) && (b <= 0 || c <= 0) || c <= 0);
            return v;
        }
    }

   
}
