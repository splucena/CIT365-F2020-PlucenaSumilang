using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskASP.Models
{
    public class SurfaceMaterial
    {
        [Key]
        public int SurfaceMaterialID { get; set; }
        public string Material { get; set; }
        public bool Active { get; set; }

        public IList<Desk> Desks { get; set; }
    }
}
