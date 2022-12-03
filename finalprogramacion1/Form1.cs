namespace finalprogramacion1
{
    public partial class Form1 : Form
    {
      private int contadorIndex = 0;
        public Form1()
        {
            InitializeComponent();
            
            

        }
        
        private void btnAlta_Click(object sender, EventArgs e)
        {
          nuevoAlumno(txtAlumno.text, txtProfesor.text, txtMateria.text); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          txtAlumno.text = "";
          txtMateria.text = "";
          txtProfesor.text = "";
          txtIndexMod.text = "";
          txtIndexBaja.text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          int index = Convert.toInt32(txtIndexMod.text);
          Form2 frmModif = new Form2(index);
          frmModif.show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void nuevoAlumno(string nombre, string profesor, string materia){
        int linea = grdClase.Rows.Add(); contadorIndex++;
        grdClase.Rows[linea].Cell[0].Value = Convert.toString(linea);
        grdClase.Rows[linea].Cell[1].Value = nombre;
        grdClase.Rows[linea].Cell[2].Value = profesor;
        grdClase.Rows[linea].Cell[3].Value = materia;
        }
    }
}
