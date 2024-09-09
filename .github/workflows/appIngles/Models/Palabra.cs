namespace appIngles.Models
{
    public class Palabra
    {
        public int idPalabra { get; set; }
        public string espaniol { get; set; }
        public string ingles { get; set; }
        public string inglesPro { get; set; }
        public string presente { get; set; }
        public string presentePro { get; set; }
        public string gerundio { get; set; }
        public string gerundioPro { get; set; }
        public string pasado { get; set; }
        public string pasadoPro { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public int idUsuario { get; set; }

    }
}
