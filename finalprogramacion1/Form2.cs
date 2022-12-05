using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalprogramacion1
{
    public partial class Form2 : Form
    {
     private static int index;

        public Form2(string nombre, string profesor, string materia)
        {
            InitializeComponent();


            txtAlumno2.Text = nombre;
            txtProfesor2.Text = profesor;
            txtMateria2.Text = materia;
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            string path = "./modificartmp";
            string txt = txtAlumno2.Text + "|" + txtProfesor2.Text + "|" + txtMateria2.Text;
            using (StreamWriter sw = new StreamWriter(path)) { 
                sw.Write(txt);
                sw.Close();
            }
            this.Close();
        }

    }
}
