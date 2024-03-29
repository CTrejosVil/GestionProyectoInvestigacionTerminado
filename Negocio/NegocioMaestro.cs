﻿using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestroEF();
        public NegocioMaestro()
        {

        }

        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<Convocatoria> ObtenerConvocatorias(int idProyecto)
        => repositorioMaestro.ObtenerConvocatorias(idProyecto);

        public List<Proyecto> ObtenerProyectos()
        => repositorioMaestro.ObtenerProyectos();

    }
}