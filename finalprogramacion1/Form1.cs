using System.Linq.Expressions;

namespace finalprogramacion1
{
    public partial class Form1 : Form
    {
        private string pathAlu = "./Alumno";
        private string pathPro = "./Profesor";
        private string pathMat = "./Materia";
        public Form1()
        {
            InitializeComponent();
              

        }
        
        private void btnAlta_Click(object sender, EventArgs e)
        {
          nuevoAlumno(txtAlumno.Text, txtProfesor.Text, txtMateria.Text); 
            
            using (var s = new StringWriter(pathAlu)) {
                s.WriteLine(txtAlumno.Text);
                s.Close();
            }
        
            using (var s = new StringWriter(pathPro))
            {
                s.WriteLine(txtProfesor.Text);
                s.Close();
            }
        
            using (var s = new StringWriter(pathMat))
            {
                s.WriteLine(txtMateria.Text);
                s.Close();
            }
          
            txtAlumno.Text = "";

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
            txtProfesorMod.Text = "";
            txtIndexMod.Text = "";
            txtIndexBaja.Text = "";
            txtMateriaMod.Text = "";
            txtNombreMod.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try{
                int index = Convert.ToInt32(txtIndexMod.Text);

                grdClase.Rows[index].Cells[1].Value = txtNombreMod.Text;
                grdClase.Rows[index].Cells[2].Value = txtProfesorMod.Text;
                grdClase.Rows[index].Cells[3].Value = txtMateriaMod.Text;
            }catch (Exception ex) { 
            
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                grdClase.Rows.RemoveAt(Convert.ToInt32(txtIndexBaja.Text));

            }catch (Exception ex)
            {

            }
            txtIndexBaja.Text = "";
        }

        private void nuevoAlumno(string nombre, string profesor, string materia){
        int linea = grdClase.Rows.Add(); contadorIndex++;
        grdClase.Rows[linea].Cells[0].Value = Convert.ToString(linea);
        grdClase.Rows[linea].Cells[1].Value = nombre;
        grdClase.Rows[linea].Cells[2].Value = profesor;
        grdClase.Rows[linea].Cells[3].Value = materia;
        }



        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIndexMod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(txtIndexMod.Text);

                txtNombreMod.Text = grdClase.Rows[index].Cells[1].Value.ToString();
                txtProfesorMod.Text = grdClase.Rows[index].Cells[2].Value.ToString();
                txtMateriaMod.Text = grdClase.Rows[index].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                txtNombreMod.Text = "";
                txtProfesorMod.Text = "";
                txtMateriaMod.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
