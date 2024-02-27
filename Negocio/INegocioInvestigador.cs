using Entidades;
namespace Negocio
{
    public class NegocioInvestigador
    {
        public interface INegocioPaciente
        {
            void IngresarPaciente(Investigador Investigador);
            void ActualizarPaciente(Investigador Investigador);
        }
    }