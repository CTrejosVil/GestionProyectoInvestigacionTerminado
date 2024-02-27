using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {iudades
        public List<Convocatoria> ObtenerConvocatorias(int idproyecto)
        {
            var convocatorias = new List<Convocatoria>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["GestionProyectoInvestigacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Convocatorias WHERE IdProyecto = @IdProyecto ORDER BY Nombre";
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@IdProyecto", idProyecto);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        convocatorias.Add(new Convocatoria()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return convocatorias;
        }

        public List<Proyecto> ObtenerProyectos()
        {
            var proyectos = new List<Proyecto>();

            var cadenaConexion = ConfigurationManager.ConnectionStrings["GestionProyectoInvestigacion"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Proyectos ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        proyectos.Add(new Proyecto()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return proyectos;
        }
    }
}
