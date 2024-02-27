using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Investigadores")]
    public class Investigador
    {
        [Key]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}