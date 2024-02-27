using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Convocatoria> ObtenerConvocatoria(int idProyecto);
        List<Proyecto> ObtenerProyecto();
    }
}