using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;

namespace Gruppe9.Models
{
    public class Eksemplar
    {
        [Key]
        public string ISBN { get; set; } = String.Empty;
        [Key]
        public int EksNr { get; set; }
    }
}
