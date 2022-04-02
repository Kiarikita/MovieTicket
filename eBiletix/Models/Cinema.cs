using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Logo gerekli.")]
        public string Logo { get; set; }

        [Display(Name = "Sinema")]
        [Required(ErrorMessage = "Sinema gerekli.")]
        public string Name { get; set; }

        [Display(Name = "Sinema Salonu Adı")]
        [Required(ErrorMessage = "Sinema Salonu Adı gerekli.")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
