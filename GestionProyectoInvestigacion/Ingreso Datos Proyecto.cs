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
    public partial class Ingreso_Datos_Proyecto : Form
    {
        public Ingreso_Datos_Proyecto()
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
                    var nombre = txtNombre.Text;
                    var grupoInvestigacion = cboGrupoInvestigacion.Text;
                    var lineaInvestigacion = cboLineaInvestigacion.Text;
                    var enteFinanciero = cboEnteFinanciero.Text;
                    String convocatoria = txtConvocatoria.Text;
                    var entidadesCooperantes = cboEntidadesCooperantes.Text;
                    var duracion = 0M;
                    String actividades = txtActividades.Text;
                    String objetivos = txtObjetivos.Text;
                    String comentarios = txtComentarios.Text;
                    var requiereAjuste = cboRequiereAjuste.Text;
                    String ajustes= txtAjustes.Text;


                //TODO: 2. Validar los datos del formulario
                if (ValidarIngreso())
                    {
                        //TODO: 3. Guardar los datos del formulario en un repositorio

                        //TODO: 4. Mostrar mensaje de confirmación/negación de la operación

                        var datos = @"Nombre: " + nombre + "\n" + "Grupo de Investigación: " + grupoInvestigacion + "\n" + "Linea de investigación: " + lineaInvestigacion + "\n" + "Ente financiero: " + enteFinanciero + "\n" + "Convocatoria: " + convocatoria + "\n" + "Entidades Cooperantes: " + entidadesCooperantes + "\n" + "Duración: " + duracion + "\n" + "Actividades: " + actividades + "\n" + "Objetivos: " + objetivos + "\n" + "Comentarios: " + comentarios + "\n" + "Requiere Ajuste: " + requiereAjuste + "\n" + "Ajustes: " + ajustes + "\n";
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
            var nombre = txtNombre.Text;
            var grupoInvestigacion = cboGrupoInvestigacion.Text;
            var lineaInvestigacion = cboLineaInvestigacion.Text;
            var enteFinanciero = cboEnteFinanciero.Text;
            String convocatoria = txtConvocatoria.Text;
            var entidadesCooperantes = cboEntidadesCooperantes.Text;
            var duracion = 0M;
            String actividades = txtActividades.Text;
            String objetivos = txtObjetivos.Text;
            String comentarios = txtComentarios.Text;
            var requiereAjuste = cboRequiereAjuste.Text;
            String ajustes = txtAjustes.Text;

            if (nombre.Trim() == "")
                {
                    MessageBox.Show("El nombre no debe estar vacío",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(grupoInvestigacion.Trim()))
                {
                    MessageBox.Show("El grupo de investigación no debe estar vacío",
                       this.Text,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(lineaInvestigacion))
                {
                    MessageBox.Show("Seleccione la linea de investigación ",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(enteFinanciero))
                {
                    MessageBox.Show("Seleccione el ente financiero",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(convocatoria))
                {
                    MessageBox.Show("La convocatoria no debe estar vacía",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrEmpty(entidadesCooperantes))
                {
                    MessageBox.Show("Las entidades cooperantes no deben estar vacías",
                      this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrEmpty(actividades))
                {
                MessageBox.Show("Las actividades no deben estar vacías",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                if (string.IsNullOrEmpty(objetivos))
            {
                MessageBox.Show("Los objetivos no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                if (string.IsNullOrEmpty(comentarios))
                {
                MessageBox.Show("Los comentarios no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                if (string.IsNullOrEmpty(requiereAjuste))
                {
                MessageBox.Show("Seleccione si requiere ajuste",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                if (string.IsNullOrEmpty(ajustes))
                {
                MessageBox.Show("Los ajustes no deben estar vacíos",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                if (string.IsNullOrEmpty(txtDuracion.Text))
                {
                MessageBox.Show("La duración no debe estar vacía",
                  this.Text,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
                }
                else
                {
                    int i = 0;
                    //while(i < Duración.TextLength)
                    //for (i = 0; i < txtDuración.TextLength; i++)
                    foreach (var caracter in txtDuracion.Text)
                    {
                         /*if (txtDuracion.Text[i] != '0' && txtDuracion.Text[i] != '1' && txtDuracion.Text[i] != '2' &&
                             txtDuracion.Text[i] != '3' && txtSDuracion.Text[i] != '4' && txtDuracion.Text[i] != '5' &&
                             txtDuracion.Text[i] != '6' && txtDuracion.Text[i] != '7' && txtDuracion.Text[i] != '8' &&
                             txtDuracion.Text[i] != '9')*/
                         if (caracter != '0' && caracter != '1' && caracter != '2' &&
                             caracter != '3' && caracter != '4' && caracter != '5' &&
                             caracter != '6' && caracter != '7' && caracter != '8' &&
                             caracter != '9')
                         {
                            MessageBox.Show("La duración solo debe tener números",
                              this.Text,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                            return false;
                         }
                         //i++;
                         //i = i + 1;
                         //i += 1;
                    }
                }

                return true;
            }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            var caracter = e.KeyChar;
            if (caracter != '0' && caracter != '1' && caracter != '2' &&
                caracter != '3' && caracter != '4' && caracter != '5' &&
                caracter != '6' && caracter != '7' && caracter != '8' &&
                caracter != '9' && (int)caracter != 8)
            {
                e.Handled = true;
            }
        }


        private void tbcDatosComplementarios_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblComenatrios_Click(object sender, EventArgs e)
        {

        }

        private void cboEntidadesCooperantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingreso_Datos_Proyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
