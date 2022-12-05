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
          nuevoAlumno(txtAlumno.Text, txtProfesor.Text, txtMateria.Text); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          txtAlumno.Text = "";
          txtMateria.Text = "";
          txtProfesor.Text = "";
          txtIndexMod.Text = "";
          txtIndexBaja.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          int index = Convert.ToInt32(txtIndexMod.Text);
          Form2 frmModif = new Form2(txtAlumno.Text, txtProfesor.Text, txtMateria.Text);
          frmModif.Show();
          
          string lineastr;
          string path = ".modificartmp";
          using (StreamReader sr = new StreamReader(path))
          {
            lineastr = sr.ReadLine();
            sr.Close();
          }
          
          if (File.Exists(path))
          {
            File.Delete(path);
          }

          var dato = lineastr.Split("|");

          grdClase.Rows[index].Cells[1].Value = dato[0];
          grdClase.Rows[index].Cells[2].Value = dato[1];
          grdClase.Rows[index].Cells[3].Value = dato[2];
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void nuevoAlumno(string nombre, string profesor, string materia){
        int linea = grdClase.Rows.Add(); contadorIndex++;
        grdClase.Rows[linea].Cells[0].Value = Convert.ToString(linea);
        grdClase.Rows[linea].Cells[1].Value = nombre;
        grdClase.Rows[linea].Cells[2].Value = profesor;
        grdClase.Rows[linea].Cells[3].Value = materia;
        }
    }
}
