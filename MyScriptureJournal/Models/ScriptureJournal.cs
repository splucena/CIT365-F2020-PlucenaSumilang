using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class ScriptureJournal
    {
        public int ID { get; set; }

        [Required]
        public string Book { get; set; }

        [Required]
        public int Chapter { get; set; }

        [Required]
        public int Verse { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Required]
        public string Note { get; set; }
    }
}
