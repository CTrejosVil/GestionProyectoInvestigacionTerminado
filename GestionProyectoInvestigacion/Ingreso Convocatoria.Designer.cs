namespace GestionProyectoInvestigacion
{
    partial class Ingreso_Convocatoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_Convocatoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaCierreConvocatoria = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAperturaConvocatoria = new System.Windows.Forms.DateTimePicker();
            this.txtTerminosReferencia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaginaWeb = new System.Windows.Forms.TextBox();
            this.lblFechaCierreConvocatoria = new System.Windows.Forms.Label();
            this.lblFechaAperturaConvocatoria = new System.Windows.Forms.Label();
            this.lblTerminosReferencia = new System.Windows.Forms.Label();
            this.lblPaginaWeb = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Covocatoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cboPais);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.dtpFechaCierreConvocatoria);
            this.groupBox1.Controls.Add(this.dtpFechaAperturaConvocatoria);
            this.groupBox1.Controls.Add(this.txtTerminosReferencia);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPaginaWeb);
            this.groupBox1.Controls.Add(this.lblFechaCierreConvocatoria);
            this.groupBox1.Controls.Add(this.lblFechaAperturaConvocatoria);
            this.groupBox1.Controls.Add(this.lblTerminosReferencia);
            this.groupBox1.Controls.Add(this.lblPaginaWeb);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(3, 344);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(760, 29);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Guardar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(760, 31);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaCierreConvocatoria
            // 
            this.dtpFechaCierreConvocatoria.Location = new System.Drawing.Point(260, 311);
            this.dtpFechaCierreConvocatoria.Name = "dtpFechaCierreConvocatoria";
            this.dtpFechaCierreConvocatoria.Size = new System.Drawing.Size(315, 20);
            this.dtpFechaCierreConvocatoria.TabIndex = 13;
            // 
            // dtpFechaAperturaConvocatoria
            // 
            this.dtpFechaAperturaConvocatoria.Location = new System.Drawing.Point(260, 268);
            this.dtpFechaAperturaConvocatoria.Name = "dtpFechaAperturaConvocatoria";
            this.dtpFechaAperturaConvocatoria.Size = new System.Drawing.Size(315, 20);
            this.dtpFechaAperturaConvocatoria.TabIndex = 12;
            // 
            // txtTerminosReferencia
            // 
            this.txtTerminosReferencia.Location = new System.Drawing.Point(208, 213);
            this.txtTerminosReferencia.Name = "txtTerminosReferencia";
            this.txtTerminosReferencia.Size = new System.Drawing.Size(367, 20);
            this.txtTerminosReferencia.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(422, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(422, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(153, 159);
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Size = new System.Drawing.Size(422, 20);
            this.txtPaginaWeb.TabIndex = 7;
            // 
            // lblFechaCierreConvocatoria
            // 
            this.lblFechaCierreConvocatoria.AutoSize = true;
            this.lblFechaCierreConvocatoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierreConvocatoria.Location = new System.Drawing.Point(42, 311);
            this.lblFechaCierreConvocatoria.Name = "lblFechaCierreConvocatoria";
            this.lblFechaCierreConvocatoria.Size = new System.Drawing.Size(190, 20);
            this.lblFechaCierreConvocatoria.TabIndex = 6;
            this.lblFechaCierreConvocatoria.Text = "Fecha Cierre Convocatoria";
            // 
            // lblFechaAperturaConvocatoria
            // 
            this.lblFechaAperturaConvocatoria.AutoSize = true;
            this.lblFechaAperturaConvocatoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAperturaConvocatoria.Location = new System.Drawing.Point(42, 268);
            this.lblFechaAperturaConvocatoria.Name = "lblFechaAperturaConvocatoria";
            this.lblFechaAperturaConvocatoria.Size = new System.Drawing.Size(212, 20);
            this.lblFechaAperturaConvocatoria.TabIndex = 5;
            this.lblFechaAperturaConvocatoria.Text = "Fecha Apertura Convocatoria";
            // 
            // lblTerminosReferencia
            // 
            this.lblTerminosReferencia.AutoSize = true;
            this.lblTerminosReferencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminosReferencia.Location = new System.Drawing.Point(42, 213);
            this.lblTerminosReferencia.Name = "lblTerminosReferencia";
            this.lblTerminosReferencia.Size = new System.Drawing.Size(152, 20);
            this.lblTerminosReferencia.TabIndex = 4;
            this.lblTerminosReferencia.Text = "Términos Referencia";
            // 
            // lblPaginaWeb
            // 
            this.lblPaginaWeb.AutoSize = true;
            this.lblPaginaWeb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaWeb.Location = new System.Drawing.Point(42, 159);
            this.lblPaginaWeb.Name = "lblPaginaWeb";
            this.lblPaginaWeb.Size = new System.Drawing.Size(92, 20);
            this.lblPaginaWeb.TabIndex = 3;
            this.lblPaginaWeb.Text = "Página Web";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(42, 113);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 20);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(42, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.Items.AddRange(new object[] {
            "Colombia",
            "Brasil",
            "Venezuela",
            "Argentina",
            "España",
            "Estados Unidos"});
            this.cboPais.Location = new System.Drawing.Point(153, 112);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(422, 21);
            this.cboPais.TabIndex = 16;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // Ingreso_Convocatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso_Convocatoria";
            this.Text = "Ingreso_Convocatoria";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaCierreConvocatoria;
        private System.Windows.Forms.Label lblFechaAperturaConvocatoria;
        private System.Windows.Forms.Label lblTerminosReferencia;
        private System.Windows.Forms.Label lblPaginaWeb;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaCierreConvocatoria;
        private System.Windows.Forms.DateTimePicker dtpFechaAperturaConvocatoria;
        private System.Windows.Forms.TextBox txtTerminosReferencia;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaginaWeb;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboPais;
    }
}