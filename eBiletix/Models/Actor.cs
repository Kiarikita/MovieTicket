using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil Resmi")]
        [Required(ErrorMessage = "Profil Resmi gerekli.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Tam Ad")]
        [Required(ErrorMessage = "Tam Ad gerekli.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tam Ad 3 ve 50 karakter arası uzunlukta olmalıdır.")]
        public string FullName { get; set; }

        [Display(Name = "Biografi")]
        [Required(ErrorMessage = "Biografi gerekli.")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
