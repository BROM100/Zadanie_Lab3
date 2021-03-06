using System.ComponentModel.DataAnnotations;

namespace Zadanie.Models
{
    public class FormModel
    {
        [Display(Name = "imię")]
        [Required]
        public string imie { get; set; }
        [Display(Name = "ilość_powtórzeń")]
        public int ilosc_powtorzen { get; set; }
        public string belongs { get; set; }
    }
}