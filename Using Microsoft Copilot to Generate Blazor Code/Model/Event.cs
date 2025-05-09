using System.ComponentModel.DataAnnotations;

namespace EventApp
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome dell'evento è obbligatorio.")]
        [StringLength(100, ErrorMessage = "Il nome dell'evento non può superare i 100 caratteri.")]
        public string EventName { get; set; } = string.Empty;

        [Required(ErrorMessage = "La data dell'evento è obbligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "La data dell'evento non è valida.")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "La posizione dell'evento è obbligatoria.")]
        [StringLength(200, ErrorMessage = "La posizione dell'evento non può superare i 200 caratteri.")]
        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public int Participants { get; set; }
    }
}
