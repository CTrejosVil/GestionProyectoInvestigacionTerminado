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
    public partial class Ingreso_Convocatoria : Form
    {
        public Ingreso_Convocatoria()
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
                var codigo = txtCodigo.Text;
                dynamic nombre = txtNombre.Text;
                var pais = cboPais.Text;
                String paginaWeb = txtPaginaWeb.Text;
                String terminosReferencia = txtTerminosReferencia.Text;
                DateTime fechaAperturaConvocatoria = dtpFechaAperturaConvocatoria.Value;
                DateTime fechaCierreConvocatoria = dtpFechaCierreConvocatoria.Value;

                //TODO: 2. Validar los datos del formulario
                if (ValidarIngreso())
                {
                    //TODO: 3. Guardar los datos del formulario en un repositorio

                    //TODO: 4. Mostrar mensaje de confirmación/negación de la operación
                   
                    var datos = @"Codigo: " + codigo + "\n" + "Nombre: " + nombre + "\n" + "Pais: " + pais + "\n" + "Pagina Web: " + paginaWeb + "\n" + "Terminos de Referencia: " + terminosReferencia + "\n" + "Fecha de Apertura de Convocatoria: " + "\n" + fechaAperturaConvocatoria.ToString("yyyy/MM/dd") + "Fecha de Cierre de Convocatoria: " + "\n" + fechaCierreConvocatoria.ToString("yyyy/MM/dd");
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
            var codigo = txtCodigo.Text;
            dynamic nombre = txtNombre.Text;
            var pais = cboPais.Text;
            String paginaWeb = txtPaginaWeb.Text;
            String terminosReferencia = txtTerminosReferencia.Text;
            DateTime fechaAperturaConvocatoria = dtpFechaAperturaConvocatoria.Value;
            DateTime fechaCierreConvocatoria = dtpFechaCierreConvocatoria.Value;

            if (codigo.Trim() == "")
            {
                MessageBox.Show("El código no debe estar vacío",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(nombre.Trim()))
            {
                MessageBox.Show("El nombre no debe estar vacío",
                   this.Text,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(pais))
            {
                MessageBox.Show("El pais no debe estar vacío",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(paginaWeb))
            {
                MessageBox.Show("La pagina web no debe estar vacía",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(terminosReferencia))
            {
                MessageBox.Show("Los términos de referencia no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (fechaAperturaConvocatoria < fechaCierreConvocatoria)
            {
                MessageBox.Show("La fecha de apertura de convocatoria no debe ser mayor a la fecha actual",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (fechaCierreConvocatoria > fechaAperturaConvocatoria)
            {
                MessageBox.Show("Digite la fecha de cierre de convocatoria ",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            return true;
         
      
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];

            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }