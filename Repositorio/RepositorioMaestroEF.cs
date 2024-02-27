using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelo.Contexto contexto;
        public RepositorioMaestroEF()
        {
            contexto = new Modelo.Contexto();
        }

        public List<Convocatoria> ObtenerConvocatorias(int idProyecto)
        {
            var convocatoria = contexto.Convocatorias.Where(d => d.Id == idProyecto)
                .Select(c => new Convocatoria() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return convocatorias;
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return contexto.Proyectos
                .Select(c => new Proyecto() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();
        }
    }
}