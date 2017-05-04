using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class User
    {
        [ScaffoldColumn(false)] // ta właściwość nie zostanie wyświetlona w formularzu
        public int userID { get; set; }
 
        [Display(Name = "Imie:")] // nazwa jaką ma się pojawić, domyślnie w naszym przypadku byłoby to "Name"
        [Required(ErrorMessage = "Musisz wprowadzić imię")] // prosta walidacja - użytkownik będzie zmuszony do wpisania wartości w polu - wartość jest wymagana, uzupelniamy rowniez tekst bledu jaki ma sie pojawic w przypadku pozostawionego pustego pola

        public string Surname { get; set; }
 
        [Display(Name = "Adres email:")]
        [Required(ErrorMessage = "Musisz wprowadzić adres e-mail")]
        [EmailAddress]
        public string EMail { get; set; }
 
        [Display(Name = "Hasło:")]
        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [StringLength(18, ErrorMessage = "Hasło powinno zawierać przynajmniej 6, a maksymalnie 18 znaków", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
 
        [Display(Name = "Powtórz hasło:")]
        [Required(ErrorMessage = "Musisz wprowadzić powtórzone hasło")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
 
        [Display(Name = "Nazwa Firmy:")]
        [Required(ErrorMessage = "Musisz wprowadzić nazwę firmy")]
        public string FirmName { get; set; }
 
        [Required(ErrorMessage = "Musisz wprowadzić NIP")]
        public int NIP { get; set; }
 
 
 
 
 
 
    }
}