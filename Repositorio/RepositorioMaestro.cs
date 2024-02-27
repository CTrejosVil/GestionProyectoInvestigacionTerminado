using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<Convocatoria> ObtenerConvocatorias(int idProyecto)
        {
            var proyectos = ObtenerProyectos();
            var convocatorias = proyectos.FirstOrDefault(d => d.Id == idProyecto).Convocatorias
                .OrderBy(c => c.Nombre)
                .ToList();

            return convocatorias;
        }

        public List<Proyecto> ObtenerProyectos()
        {
            var proyectos = new List<Proyecto>();

            proyectos.Add(new proyecto() { Id = 1, Nombre = "Corazones sanos", Convocatorias = new List<Convocatoria>() });
            proyectos[0].Convocatorias.Add(new Convocatoria() { Id = 1, Nombre = "Sede A" });
            proyectos[0].Convocatorias.Add(new Convocatoria() { Id = 2, Nombre = "Sede B" });
            proyectos[0].Convocatorias.Add(new Convocatoria() { Id = 3, Nombre = "Sede C" });

            proyectos.Add(new Departamento() { Id = 2, Nombre = "Vida sin infecciones", Ciudades = new List<Convocatoria>() });
            proyectos[1].Convocatorias.Add(new Convocatoria() { Id = 4, Nombre = "Sede D" });
            proyectos[1].Convocatorias.Add(new Convocatoria() { Id = 5, Nombre = "Sede E" });
            proyectos[1].Convocatorias.Add(new Convocatoria() { Id = 6, Nombre = "Sede F" });

            proyectos.Add(new Departamento() { Id = 3, Nombre = "Salud para todos", Ciudades = new List<Convocatoria>() });
            proyectos[2].Convocatorias.Add(new Convocatoria() { Id = 7, Nombre = "Sede G" });
            proyectos[2].Convocatorias.Add(new Convocatoria() { Id = 8, Nombre = "Sede H" });
            proyectos[2].Convocatorias.Add(new Convocatoria() { Id = 9, Nombre = "Sede I" });

            return proyectos;
        }

        }
    }
}