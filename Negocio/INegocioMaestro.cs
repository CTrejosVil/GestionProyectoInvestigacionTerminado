namespace Negocio
{
    public class INegocioMaestro
    {
        List<Proyecto> ObtenerProyectos();
        List<Convocatoria> ObtenerConvocatorias(int idProyecto);
    }
}