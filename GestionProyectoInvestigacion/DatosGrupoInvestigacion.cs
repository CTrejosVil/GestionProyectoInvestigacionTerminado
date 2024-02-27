using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectoInvestigacion
{
    public partial class DatosGrupoInvestigacion : Form
    {
        public DatosGrupoInvestigacion()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que permite guardar los datos de un investigador
        /// </summary>
        /// <param name="sender">Control que desencadena el evento</param>
        /// <param name="e">Datos del evento</param>
        /// <remarks></remarks>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: 1. Recuperar los datos del formulario
                /*
                 En este paso asignamos los valores de los controles a
                 variables locales
                 */
                var unidad= txtUnidad.Text;
                dynamic entidades = txtEntidades.Text;
                var integrantes =cboIntegrantes.Text;
                var investigadorPrincipal = cboInvestigadorPrincipal.Text;
                
                //TODO: 2. Validar los datos del formulario
                if (ValidarIngreso())
                {
                    //TODO: 3. Guardar los datos del formulario en un repositorio

                    //TODO: 4. Mostrar mensaje de confirmación/negación de la operación

                    var datos = @"Unidad: " + unidad + "\n" + "Entidades: " + entidades + "\n" + "Integrantes: " + integrantes + "\n" + "Investidador principal: " + investigadorPrincipal + "\n";
                    MessageBox.Show(datos, "Datos Ingreso Convocatoria",
                        MessageBoxButtons.OK);
                }

                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Por ahora el sistema tiene dificultades. Volveremos pronto.  " +
                    "El error presentado es: " + ex.Message,
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private bool ValidarIngreso()
        {
            var unidad = txtUnidad.Text;
            dynamic entidades = txtEntidades.Text;
            var integrantes = cboIntegrantes.Text;
            var investigadorPrincipal = cboInvestigadorPrincipal.Text;

            if (unidad.Trim() == "")
            {
                MessageBox.Show("La unidad no debe estar vacía",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(entidades.Trim()))
            {
                MessageBox.Show("Las entidades no deben estar vacías",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(integrantes))
            {
                MessageBox.Show("Los integrantes no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(investigadorPrincipal))
            {
                MessageBox.Show("El investigador principal no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            
            return true;


        }

        private void txtInvestigadorPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosGrupoInvestigacion_Load(object sender, EventArgs e)
        {

        }

        private void cboIntegrantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
