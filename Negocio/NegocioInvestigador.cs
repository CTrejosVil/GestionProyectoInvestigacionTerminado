using Entidades;
using Repositorio;

namespace Negocio
{
    public class NegocioInvestigador : INegocioInvestigador
    {
        IRepositorioInvestigador repositorioInvestigador;
        public NegocioInvestigador(IRepositorioInvestigador repositorioInvestigador)
        {
            this.repositorioInvestigador = repositorioInvestigador;
        }

        public void ActualizarInvestigador(Investigador Investigador)
        => this.repositorioInvestigador.ActualizarInvestigador(Investigador);

        public void IngresarInvestigador(Investigador Investigador)
        => this.repositorioInvestigador.IngresarInvestigador(Investigador);

    }
}
