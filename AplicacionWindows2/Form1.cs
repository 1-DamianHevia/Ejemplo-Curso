using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String apellido, nombre, direccion;
            int edad;

            if (txtApellido.Text == "")
     
                txtApellido.BackColor = Color.Red;

            
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;

            if(txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;

            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "")

            {
                apellido = txtApellido.Text;
                nombre = txtNombre.Text;
                edad = Convert.ToInt32(txtEdad.Text);
                direccion = txtDireccion.Text;

                txtResultado.Text = "Apellido y Nombre: " + apellido + ", " + nombre + Environment.NewLine + "Edad: " + edad + Environment.NewLine + "Direcion: " + direccion;
                


            }


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmDatosPersonales.ActiveForm.Close();
        }
    }
}
