namespace finalprogramacion1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grdClase = new System.Windows.Forms.DataGridView();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtIndexMod = new System.Windows.Forms.TextBox();
            this.txtIndexBaja = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblBaja = new System.Windows.Forms.Label();
            this.lblAlta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(377, 205);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(377, 119);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(543, 205);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(583, 350);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grdClase
            // 
            this.grdClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumno,
            this.profesor,
            this.materia});
            this.grdClase.Location = new System.Drawing.Point(12, 12);
            this.grdClase.Name = "grdClase";
            this.grdClase.RowTemplate.Height = 25;
            this.grdClase.Size = new System.Drawing.Size(344, 361);
            this.grdClase.TabIndex = 4;
            // 
            // alumno
            // 
            this.alumno.HeaderText = "Alumno";
            this.alumno.Name = "alumno";
            // 
            // profesor
            // 
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            // 
            // materia
            // 
            this.materia.HeaderText = "Materia ";
            this.materia.Name = "materia";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(368, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Cajas de Texto";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(368, 32);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 23);
            this.txtAlumno.TabIndex = 6;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(368, 90);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 23);
            this.txtMateria.TabIndex = 7;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(368, 61);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 23);
            this.txtProfesor.TabIndex = 8;
            // 
            // txtIndexMod
            // 
            this.txtIndexMod.Location = new System.Drawing.Point(368, 176);
            this.txtIndexMod.Name = "txtIndexMod";
            this.txtIndexMod.Size = new System.Drawing.Size(100, 23);
            this.txtIndexMod.TabIndex = 12;
            // 
            // txtIndexBaja
            // 
            this.txtIndexBaja.Location = new System.Drawing.Point(531, 176);
            this.txtIndexBaja.Name = "txtIndexBaja";
            this.txtIndexBaja.Size = new System.Drawing.Size(100, 23);
            this.txtIndexBaja.TabIndex = 13;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(474, 64);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(117, 15);
            this.lblProfesor.TabIndex = 14;
            this.lblProfesor.Text = "Nombre del Profesor";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(474, 35);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(172, 15);
            this.lblAlumno.TabIndex = 15;
            this.lblAlumno.Text = "Apellido y Nombre del Alumno";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(474, 93);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(122, 15);
            this.lblMateria.TabIndex = 16;
            this.lblMateria.Text = "Nombre de la Materia";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(474, 179);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(53, 15);
            this.lblIndex.TabIndex = 17;
            this.lblIndex.Text = "N° Index";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(387, 158);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(58, 15);
            this.lblMod.TabIndex = 21;
            this.lblMod.Text = "Modificar";
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.Location = new System.Drawing.Point(567, 158);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(29, 15);
            this.lblBaja.TabIndex = 23;
            this.lblBaja.Text = "Baja";
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Location = new System.Drawing.Point(387, 14);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(65, 15);
            this.lblAlta.TabIndex = 24;
            this.lblAlta.Text = "Dar de Alta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 377);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.txtIndexBaja);
            this.Controls.Add(this.txtIndexMod);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grdClase);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnModificar);
            this.Name = "Form1";
            this.Text = "Proyecto Final Programacion1";
            ((System.ComponentModel.ISupportInitialize)(this.grdClase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModificar;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnCerrar;
        private DataGridView grdClase;
        private DataGridViewTextBoxColumn alumno;
        private DataGridViewTextBoxColumn profesor;
        private DataGridViewTextBoxColumn materia;
        private Button btnLimpiar;
        private TextBox txtAlumno;
        private TextBox txtMateria;
        private TextBox txtProfesor;
        private TextBox txtIndexMod;
        private TextBox txtIndexBaja;
        private Label lblProfesor;
        private Label lblAlumno;
        private Label lblMateria;
        private Label lblIndex;
        private Label lblMod;
        private Label lblBaja;
        private Label lblAlta;
    }
}
