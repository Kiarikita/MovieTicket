using eBiletix.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBiletix.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad gerekli.")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama gerekli.")]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat gerekli.")]
        public double Price { get; set; }

        [Display(Name = "Resim")]
        [Required(ErrorMessage = "Resim gerekli.")]
        public string ImageURL { get; set; }

        [Display(Name = "Film Başlangıç Tarihi")]
        [Required(ErrorMessage = "Başlangıç tarihi gerekli.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Film Bitiş Tarihi")]
        [Required(ErrorMessage = "Bitiş tarihi gerekli.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Kategori Seç")]
        [Required(ErrorMessage = "Film kategorisi gerekli.")]
        public MovieCategory MovieCategory { get; set; }

        //relationships
        [Display(Name = "Aktör/leri Seç")]
        [Required(ErrorMessage = "Aktör gerekli.")]
        public List<int> ActorIds { get; set; }

        //cinema
        [Display(Name = "Sinema Salonu Seç")]
        [Required(ErrorMessage = "Sinema Salonu gerekli.")]
        public int CinemaId { get; set; }

        //producer
        [Display(Name = "Yapımcı Seç")]
        [Required(ErrorMessage = "Yapımcı gerekli.")]
        public int ProducerId { get; set; }
    }
}
