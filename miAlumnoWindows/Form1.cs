using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miAlumnoWindows
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPromedio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Las Acciones que pasaran cuando precione el boton Registrar
            Alumno a;
            a = new Alumno();
            a.pLegajo = Convert.ToInt32(txtLegajo.Text);
            a.pDocumento = Convert.ToInt32(txtDocumento.Text);
            a.pNota1 = Convert.ToDouble(txtNota1.Text);
            a.pNota2 = Convert.ToDouble(txtNota2.Text);
            a.pNombre = txtNombre.Text;

            //esto muestra el promedio en la caja de texto de promedio
            txtPromedio.Text = Convert.ToString(a.calcularPromedio());

            MessageBox.Show(a.toString(), "Informacion");
        }
    }
}
