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
     private static string nombre, profesor, materia;
     private static dataFridView grdClase;
        public Form2(int index, ref dataGridView grdClase, string nombre, string profesor, string materia)
        {
            InitializeComponent();
            this.index = index;
            this.grdClase = grdClase;
            this.nombre = nombre;
            this.profesor = profesor;
            this.materia = materia;
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void btnModif2_Click(object sender, EventArgs e)
        {

          grdClase.Rows[index].Cell[1].Value = txtAlumno2.text;
          grdClase.Rows[index].Cell[2].Value = txtProfesor2.text;
          grdClase.Rows[index].Cell[3].Value = txtMateria2.text;
        }
    }
}
