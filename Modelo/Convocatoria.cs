using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Convocatorias")]
    public class Convocatoria
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]

            public int Id { get; set; }
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Pais { get; set; }
            public string PaginaWeb { get; set; }
            public string TerminosReferencia { get; set; }
            public DateTime FechaAperturaConvocatoria { get; set; }
            public DateTime FechaCierreConvocatoria { get; set; }
            public int IdProyecto { get; set; }

        public virtual Proyecto Proyecto  { get; set; }

            public virtual ICollection<Investigador> Investigadores  { get; set; }
        }
    }