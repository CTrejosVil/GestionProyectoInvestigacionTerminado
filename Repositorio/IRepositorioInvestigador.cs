using Entidades;
namespace Negocio
{
    internal interface IRepositorioInvestigador
    {
        void IngresarConvocatoria(Convocatoria Convocatoria);
        void ActualizarPaciente(Convocatoria Convocatoria);

    }
}