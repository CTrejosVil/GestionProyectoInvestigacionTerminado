using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Investigaciones")]
    public class Investigacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Proyecto Proyecto { get; set; }

        public virtual Proyecto Proyectos { get; set; }

        public virtual ICollection<Investigador> Investigadores { get; set; }
    }
}