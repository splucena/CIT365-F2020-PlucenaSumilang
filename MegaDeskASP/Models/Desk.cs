using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MegaDeskASP.Models
{
    public class Desk
    {
        [Key]
        public int DeskID { get; set; }

        [Required]
        public decimal Width { get; set; }

        [Required]
        public decimal Height { get; set; }
        public int RushOrderDay { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public decimal Amount { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public int SurfaceMaterialID { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
    }
}
