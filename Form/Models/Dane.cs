using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Form.Models
{
    public class Dane
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj imie")]
        [MinLength(2)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Podaj email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj haslo")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Uzyj co najmniej jednej duzej litery, jednej malej i jednej cyfry")]
        [MinLength(8)]
        public string Haslo { get; set; }
        [Required(ErrorMessage = "Powtorz haslo")]
        [Compare("Haslo")]
        public string Haslo2 { get; set; }
        [Required(ErrorMessage = "Podaj numer telefonu")]
        [Phone]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Podaj wiek")]
        [Range(10,80)]
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Wybierz miasto")]
        public string Miasto { get; set; }
        public enum Miasta {Krakow = 1, Lodz = 2, Radom = 3, Kielce = 4, Poznan = 5 }
        
    }
}
