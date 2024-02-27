namespace GestionProyectoInvestigacion
{
    partial class Ingreso_Datos_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_Datos_Proyecto));
            this.tbcDatosProyecto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtConvocatoria = new System.Windows.Forms.TextBox();
            this.cboEnteFinanciero = new System.Windows.Forms.ComboBox();
            this.cboLineaInvestigacion = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEntidadesCooperantes = new System.Windows.Forms.Label();
            this.lblConvocatoria = new System.Windows.Forms.Label();
            this.lblEnteFinanciero = new System.Windows.Forms.Label();
            this.lblLineaInvestigacion = new System.Windows.Forms.Label();
            this.lblGrupoInvestigacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbcDatosComplementarios = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboRequiereAjuste = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtActividades = new System.Windows.Forms.TextBox();
            this.txtObjetivos = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtAjustes = new System.Windows.Forms.TextBox();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.lblRequiereAjuste = new System.Windows.Forms.Label();
            this.lblComenatrios = new System.Windows.Forms.Label();
            this.lblObjetivos = new System.Windows.Forms.Label();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.cboGrupoInvestigacion = new System.Windows.Forms.ComboBox();
            this.cboEntidadesCooperantes = new System.Windows.Forms.ComboBox();
            this.tbcDatosProyecto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbcDatosComplementarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDatosProyecto
            // 
            this.tbcDatosProyecto.Controls.Add(this.tabPage1);
            this.tbcDatosProyecto.Controls.Add(this.tbcDatosComplementarios);
            this.tbcDatosProyecto.Location = new System.Drawing.Point(0, 0);
            this.tbcDatosProyecto.Name = "tbcDatosProyecto";
            this.tbcDatosProyecto.SelectedIndex = 0;
            this.tbcDatosProyecto.Size = new System.Drawing.Size(800, 451);
            this.tbcDatosProyecto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.cboEntidadesCooperantes);
            this.tabPage1.Controls.Add(this.cboGrupoInvestigacion);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.txtConvocatoria);
            this.tabPage1.Controls.Add(this.cboEnteFinanciero);
            this.tabPage1.Controls.Add(this.cboLineaInvestigacion);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblEntidadesCooperantes);
            this.tabPage1.Controls.Add(this.lblConvocatoria);
            this.tabPage1.Controls.Add(this.lblEnteFinanciero);
            this.tabPage1.Controls.Add(this.lblLineaInvestigacion);
            this.tabPage1.Controls.Add(this.lblGrupoInvestigacion);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Proyecto";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(3, 284);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(786, 69);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Guardar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(786, 64);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtConvocatoria
            // 
            this.txtConvocatoria.Location = new System.Drawing.Point(251, 205);
            this.txtConvocatoria.Name = "txtConvocatoria";
            this.txtConvocatoria.Size = new System.Drawing.Size(357, 20);
            this.txtConvocatoria.TabIndex = 8;
            // 
            // cboEnteFinanciero
            // 
            this.cboEnteFinanciero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnteFinanciero.FormattingEnabled = true;
            this.cboEnteFinanciero.Items.AddRange(new object[] {
            "Bancolombia",
            "BBVA",
            "Davivienda",
            "Banco Popular",
            "Banco de Bogotá",
            "Banco de Occidente",
            "Banco Agrario"});
            this.cboEnteFinanciero.Location = new System.Drawing.Point(251, 155);
            this.cboEnteFinanciero.Name = "cboEnteFinanciero";
            this.cboEnteFinanciero.Size = new System.Drawing.Size(357, 21);
            this.cboEnteFinanciero.TabIndex = 9;
            // 
            // cboLineaInvestigacion
            // 
            this.cboLineaInvestigacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineaInvestigacion.FormattingEnabled = true;
            this.cboLineaInvestigacion.Items.AddRange(new object[] {
            "Cardiología",
            "Epidemiología",
            "Salud Mental",
            "Enfermedades Infecciosas",
            "Enfermedades Crónicas"});
            this.cboLineaInvestigacion.Location = new System.Drawing.Point(251, 106);
            this.cboLineaInvestigacion.Name = "cboLineaInvestigacion";
            this.cboLineaInvestigacion.Size = new System.Drawing.Size(357, 21);
            this.cboLineaInvestigacion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(408, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblEntidadesCooperantes
            // 
            this.lblEntidadesCooperantes.AutoSize = true;
            this.lblEntidadesCooperantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadesCooperantes.Location = new System.Drawing.Point(60, 260);
            this.lblEntidadesCooperantes.Name = "lblEntidadesCooperantes";
            this.lblEntidadesCooperantes.Size = new System.Drawing.Size(149, 17);
            this.lblEntidadesCooperantes.TabIndex = 5;
            this.lblEntidadesCooperantes.Text = "Entidades Cooperantes";
            // 
            // lblConvocatoria
            // 
            this.lblConvocatoria.AutoSize = true;
            this.lblConvocatoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvocatoria.Location = new System.Drawing.Point(60, 205);
            this.lblConvocatoria.Name = "lblConvocatoria";
            this.lblConvocatoria.Size = new System.Drawing.Size(89, 17);
            this.lblConvocatoria.TabIndex = 4;
            this.lblConvocatoria.Text = "Convocatoria";
            // 
            // lblEnteFinanciero
            // 
            this.lblEnteFinanciero.AutoSize = true;
            this.lblEnteFinanciero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteFinanciero.Location = new System.Drawing.Point(60, 155);
            this.lblEnteFinanciero.Name = "lblEnteFinanciero";
            this.lblEnteFinanciero.Size = new System.Drawing.Size(103, 17);
            this.lblEnteFinanciero.TabIndex = 3;
            this.lblEnteFinanciero.Text = "Ente Financiero";
            // 
            // lblLineaInvestigacion
            // 
            this.lblLineaInvestigacion.AutoSize = true;
            this.lblLineaInvestigacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineaInvestigacion.Location = new System.Drawing.Point(60, 106);
            this.lblLineaInvestigacion.Name = "lblLineaInvestigacion";
            this.lblLineaInvestigacion.Size = new System.Drawing.Size(146, 17);
            this.lblLineaInvestigacion.TabIndex = 2;
            this.lblLineaInvestigacion.Text = "Línea de Investigación";
            // 
            // lblGrupoInvestigacion
            // 
            this.lblGrupoInvestigacion.AutoSize = true;
            this.lblGrupoInvestigacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoInvestigacion.Location = new System.Drawing.Point(54, 56);
            this.lblGrupoInvestigacion.Name = "lblGrupoInvestigacion";
            this.lblGrupoInvestigacion.Size = new System.Drawing.Size(151, 17);
            this.lblGrupoInvestigacion.TabIndex = 1;
            this.lblGrupoInvestigacion.Text = "Grupo de Investigación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbcDatosComplementarios
            // 
            this.tbcDatosComplementarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcDatosComplementarios.BackgroundImage")));
            this.tbcDatosComplementarios.Controls.Add(this.button1);
            this.tbcDatosComplementarios.Controls.Add(this.button2);
            this.tbcDatosComplementarios.Controls.Add(this.cboRequiereAjuste);
            this.tbcDatosComplementarios.Controls.Add(this.txtDuracion);
            this.tbcDatosComplementarios.Controls.Add(this.txtActividades);
            this.tbcDatosComplementarios.Controls.Add(this.txtObjetivos);
            this.tbcDatosComplementarios.Controls.Add(this.txtComentarios);
            this.tbcDatosComplementarios.Controls.Add(this.txtAjustes);
            this.tbcDatosComplementarios.Controls.Add(this.lblAjustes);
            this.tbcDatosComplementarios.Controls.Add(this.lblRequiereAjuste);
            this.tbcDatosComplementarios.Controls.Add(this.lblComenatrios);
            this.tbcDatosComplementarios.Controls.Add(this.lblObjetivos);
            this.tbcDatosComplementarios.Controls.Add(this.lblActividades);
            this.tbcDatosComplementarios.Controls.Add(this.lblDuracion);
            this.tbcDatosComplementarios.Location = new System.Drawing.Point(4, 22);
            this.tbcDatosComplementarios.Name = "tbcDatosComplementarios";
            this.tbcDatosComplementarios.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbcDatosComplementarios.Size = new System.Drawing.Size(792, 425);
            this.tbcDatosComplementarios.TabIndex = 1;
            this.tbcDatosComplementarios.Text = "Datos Complementarios";
            this.tbcDatosComplementarios.UseVisualStyleBackColor = true;
            this.tbcDatosComplementarios.Click += new System.EventHandler(this.tbcDatosComplementarios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(786, 69);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(786, 64);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cboRequiereAjuste
            // 
            this.cboRequiereAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequiereAjuste.FormattingEnabled = true;
            this.cboRequiereAjuste.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cboRequiereAjuste.Location = new System.Drawing.Point(203, 194);
            this.cboRequiereAjuste.Name = "cboRequiereAjuste";
            this.cboRequiereAjuste.Size = new System.Drawing.Size(333, 21);
            this.cboRequiereAjuste.TabIndex = 16;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(186, 19);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(350, 20);
            this.txtDuracion.TabIndex = 15;
            this.txtDuracion.TextChanged += new System.EventHandler(this.txtDuracion_TextChanged);
            // 
            // txtActividades
            // 
            this.txtActividades.Location = new System.Drawing.Point(186, 63);
            this.txtActividades.Name = "txtActividades";
            this.txtActividades.Size = new System.Drawing.Size(350, 20);
            this.txtActividades.TabIndex = 14;
            // 
            // txtObjetivos
            // 
            this.txtObjetivos.Location = new System.Drawing.Point(186, 109);
            this.txtObjetivos.Name = "txtObjetivos";
            this.txtObjetivos.Size = new System.Drawing.Size(350, 20);
            this.txtObjetivos.TabIndex = 13;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(186, 150);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(350, 20);
            this.txtComentarios.TabIndex = 12;
            // 
            // txtAjustes
            // 
            this.txtAjustes.Location = new System.Drawing.Point(186, 245);
            this.txtAjustes.Name = "txtAjustes";
            this.txtAjustes.Size = new System.Drawing.Size(350, 20);
            this.txtAjustes.TabIndex = 11;
            // 
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(74, 248);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(53, 17);
            this.lblAjustes.TabIndex = 10;
            this.lblAjustes.Text = "Ajustes";
            // 
            // lblRequiereAjuste
            // 
            this.lblRequiereAjuste.AutoSize = true;
            this.lblRequiereAjuste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiereAjuste.Location = new System.Drawing.Point(74, 198);
            this.lblRequiereAjuste.Name = "lblRequiereAjuste";
            this.lblRequiereAjuste.Size = new System.Drawing.Size(105, 17);
            this.lblRequiereAjuste.TabIndex = 9;
            this.lblRequiereAjuste.Text = "Requiere Ajuste";
            // 
            // lblComenatrios
            // 
            this.lblComenatrios.AutoSize = true;
            this.lblComenatrios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComenatrios.Location = new System.Drawing.Point(74, 153);
            this.lblComenatrios.Name = "lblComenatrios";
            this.lblComenatrios.Size = new System.Drawing.Size(86, 17);
            this.lblComenatrios.TabIndex = 8;
            this.lblComenatrios.Text = "Comentarios";
            this.lblComenatrios.Click += new System.EventHandler(this.lblComenatrios_Click);
            // 
            // lblObjetivos
            // 
            this.lblObjetivos.AutoSize = true;
            this.lblObjetivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivos.Location = new System.Drawing.Point(74, 112);
            this.lblObjetivos.Name = "lblObjetivos";
            this.lblObjetivos.Size = new System.Drawing.Size(67, 17);
            this.lblObjetivos.TabIndex = 7;
            this.lblObjetivos.Text = "Objetivos";
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.Location = new System.Drawing.Point(74, 66);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(79, 17);
            this.lblActividades.TabIndex = 6;
            this.lblActividades.Text = "Actividades";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(74, 22);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(64, 17);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración";
            // 
            // cboGrupoInvestigacion
            // 
            this.cboGrupoInvestigacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupoInvestigacion.FormattingEnabled = true;
            this.cboGrupoInvestigacion.Items.AddRange(new object[] {
            "Semillero de investigación en Salud Mental ",
            "Semillero de investigación en enfermedades crónicas",
            "Semillero de investigación en enfermedades cardiovasculares",
            "Semillero de investigación en enfermedades infecciosas",
            "Semillero de investigación en epidemiología"});
            this.cboGrupoInvestigacion.Location = new System.Drawing.Point(251, 56);
            this.cboGrupoInvestigacion.Name = "cboGrupoInvestigacion";
            this.cboGrupoInvestigacion.Size = new System.Drawing.Size(357, 21);
            this.cboGrupoInvestigacion.TabIndex = 13;
            // 
            // cboEntidadesCooperantes
            // 
            this.cboEntidadesCooperantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidadesCooperantes.FormattingEnabled = true;
            this.cboEntidadesCooperantes.Items.AddRange(new object[] {
            "Universidad de Antioquia",
            "Ministerio de Educación ",
            "Organización Mundial de la Salud ",
            "Organización Panamericana de la Salud",
            "Banco Mundial "});
            this.cboEntidadesCooperantes.Location = new System.Drawing.Point(251, 256);
            this.cboEntidadesCooperantes.Name = "cboEntidadesCooperantes";
            this.cboEntidadesCooperantes.Size = new System.Drawing.Size(357, 21);
            this.cboEntidadesCooperantes.TabIndex = 14;
            this.cboEntidadesCooperantes.SelectedIndexChanged += new System.EventHandler(this.cboEntidadesCooperantes_SelectedIndexChanged);
            // 
            // Ingreso_Datos_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcDatosProyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso_Datos_Proyecto";
            this.Text = "Ingreso Datos Proyecto";
            this.Load += new System.EventHandler(this.Ingreso_Datos_Proyecto_Load);
            this.tbcDatosProyecto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbcDatosComplementarios.ResumeLayout(false);
            this.tbcDatosComplementarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDatosProyecto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbcDatosComplementarios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEntidadesCooperantes;
        private System.Windows.Forms.Label lblConvocatoria;
        private System.Windows.Forms.Label lblEnteFinanciero;
        private System.Windows.Forms.Label lblLineaInvestigacion;
        private System.Windows.Forms.Label lblGrupoInvestigacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtConvocatoria;
        private System.Windows.Forms.ComboBox cboEnteFinanciero;
        private System.Windows.Forms.ComboBox cboLineaInvestigacion;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.Label lblRequiereAjuste;
        private System.Windows.Forms.Label lblComenatrios;
        private System.Windows.Forms.Label lblObjetivos;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ComboBox cboRequiereAjuste;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtActividades;
        private System.Windows.Forms.TextBox txtObjetivos;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtAjustes;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboEntidadesCooperantes;
        private System.Windows.Forms.ComboBox cboGrupoInvestigacion;
    }
}