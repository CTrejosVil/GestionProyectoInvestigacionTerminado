using Entidades;
using Negocio;
using System.Reflection;

namespace Repositorio
{
    public class RepositorioInvestigador : IRepositorioInvestigador
    {
        private Modelo.Contexto contexto;
        public RepositorioInvestigador()
        {
            contexto = new Modelo.Contexto();
        }

        public void IngresarInvestigador(Investigador Investigador)
        {
            Modelo.Investigador InvestigadorIngresar = new Modelo.Investigador()
            {
                Codigo = Investigador.Codigo,
                Nombre = Investigador.Nombre,
                Pais = Investigador.Pais,
                PaginaWeb = Investigador.PaginaWeb,
                TerminosReferencia = Investigador.TerminosReferencia,
                FechaAperturaConvocatoria = Investigador.FechaAperturaConvocatoria,
                FechaCierreConvocatoria = Investigador.FechaCierreConvocatoria,
            };

            contexto.Investigadores.Add(investigadorIngresar);
            contexto.SaveChanges();
        }

        public void ActualizarInvestigador(Investigador Investigador)
        {
            var InvestigadorActual = contexto.Investigadores.FirstOrDefault(p => p.Id == investigador.Id);
            InvestigadorActual.Codigo = Investigador.Codigo;
            InvestigadorActual.Nombre = Investigador.Nombre;
            InvestigadorActual.Pais = Investigador.Pais;
            InvestigadorActual.PaginaWeb = Investigador.PaginaWeb;
            InvestigadorActual.TerminosReferencia = Investigador.TerminosReferencia;
            InvestigadorActual.FechaAperturaConvocatoria = Investigador.FechaAperturaConvocatoria.Id;
            InvestigadorActual.FechaCierreConvocatoria = Investigador.FechaCierreConvocatoria;
           

            contexto.SaveChanges();
        }

    }
}
