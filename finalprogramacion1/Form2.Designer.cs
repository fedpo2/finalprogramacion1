namespace finalprogramacion1
{
    partial class Form2
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
            this.lblMateria2 = new System.Windows.Forms.Label();
            this.lblAlumno2 = new System.Windows.Forms.Label();
            this.lblProfesor2 = new System.Windows.Forms.Label();
            this.txtProfesor2 = new System.Windows.Forms.TextBox();
            this.txtMateria2 = new System.Windows.Forms.TextBox();
            this.txtAlumno2 = new System.Windows.Forms.TextBox();
            this.btnModif2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMateria2
            // 
            this.lblMateria2.AutoSize = true;
            this.lblMateria2.Location = new System.Drawing.Point(116, 69);
            this.lblMateria2.Name = "lblMateria2";
            this.lblMateria2.Size = new System.Drawing.Size(122, 15);
            this.lblMateria2.TabIndex = 23;
            this.lblMateria2.Text = "Nombre de la Materia";
            // 
            // lblAlumno2
            // 
            this.lblAlumno2.AutoSize = true;
            this.lblAlumno2.Location = new System.Drawing.Point(116, 11);
            this.lblAlumno2.Name = "lblAlumno2";
            this.lblAlumno2.Size = new System.Drawing.Size(172, 15);
            this.lblAlumno2.TabIndex = 22;
            this.lblAlumno2.Text = "Apellido y Nombre del Alumno";
            // 
            // lblProfesor2
            // 
            this.lblProfesor2.AutoSize = true;
            this.lblProfesor2.Location = new System.Drawing.Point(116, 40);
            this.lblProfesor2.Name = "lblProfesor2";
            this.lblProfesor2.Size = new System.Drawing.Size(117, 15);
            this.lblProfesor2.TabIndex = 21;
            this.lblProfesor2.Text = "Nombre del Profesor";
            // 
            // txtProfesor2
            // 
            this.txtProfesor2.Location = new System.Drawing.Point(10, 40);
            this.txtProfesor2.Name = "txtProfesor2";
            this.txtProfesor2.Size = new System.Drawing.Size(100, 23);
            this.txtProfesor2.TabIndex = 20;
            // 
            // txtMateria2
            // 
            this.txtMateria2.Location = new System.Drawing.Point(10, 69);
            this.txtMateria2.Name = "txtMateria2";
            this.txtMateria2.Size = new System.Drawing.Size(100, 23);
            this.txtMateria2.TabIndex = 19;
            // 
            // txtAlumno2
            // 
            this.txtAlumno2.Location = new System.Drawing.Point(10, 11);
            this.txtAlumno2.Name = "txtAlumno2";
            this.txtAlumno2.Size = new System.Drawing.Size(100, 23);
            this.txtAlumno2.TabIndex = 18;
            // 
            // btnModif2
            // 
            this.btnModif2.Location = new System.Drawing.Point(19, 98);
            this.btnModif2.Name = "btnModif2";
            this.btnModif2.Size = new System.Drawing.Size(75, 23);
            this.btnModif2.TabIndex = 17;
            this.btnModif2.Text = "Modificar";
            this.btnModif2.UseVisualStyleBackColor = true;
            this.btnModif2.Click += new System.EventHandler(this.btnModif2_Click);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Location = new System.Drawing.Point(213, 98);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar2.TabIndex = 24;
            this.btnCerrar2.Text = "Cerrar";
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 126);
            this.Controls.Add(this.btnCerrar2);
            this.Controls.Add(this.lblMateria2);
            this.Controls.Add(this.lblAlumno2);
            this.Controls.Add(this.lblProfesor2);
            this.Controls.Add(this.txtProfesor2);
            this.Controls.Add(this.txtMateria2);
            this.Controls.Add(this.txtAlumno2);
            this.Controls.Add(this.btnModif2);
            this.Name = "Form2";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMateria2;
        private Label lblAlumno2;
        private Label lblProfesor2;
        private TextBox txtProfesor2;
        private TextBox txtMateria2;
        private TextBox txtAlumno2;
        private Button btnModif2;
        private Button btnCerrar2;
    }
}