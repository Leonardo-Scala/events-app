using System.ComponentModel.DataAnnotations;

namespace EventApp
{
    public class User
    {
        [Required(ErrorMessage = "Il campo Username è obbligatorio.")]
        [StringLength(50, ErrorMessage = "Il campo Username non può superare i 50 caratteri.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Il campo Email è obbligatorio.")]
        [EmailAddress(ErrorMessage = "Inserisci un indirizzo email valido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Il campo Password è obbligatorio.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La password deve essere compresa tra 6 e 100 caratteri.")]
        public string Password { get; set; } = string.Empty;
    }
}
