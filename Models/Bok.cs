using System.ComponentModel.DataAnnotations;

namespace Gruppe9.Models
{
    public class Bok
    {
        [Key]
        public string ISBN { get; set; } = String.Empty;
        public string Tittel { get; set; } = String.Empty;
        public string Forfatter { get; set; } = String.Empty;
        public string Forlag { get; set; } = String.Empty;
        public int UtgittÅr { get; set; }
        public int AntallSider { get; set; }

        public List<Eksemplar> Eksemplar { get; set; }

    }
}
