using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCUEVASSP1DEFINITIVA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int i = 0; //Contador para intentos fallidos


        private void txtContrasenia_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContrasenia.Enabled = true;
                cmbModulo.Enabled = true;

            }
            else

            {
                txtContrasenia.Text = "";
                cmbModulo.SelectedIndex = -1;
                txtContrasenia.Enabled = false;
                cmbModulo.Enabled = false;


            }
            cmbModulo.Items.Clear();
            if (txtUsuario.Text == "Adm")
            {
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("COM");
                cmbModulo.Items.Add("VTA");


            }
            else if (txtUsuario.Text == "John")
            {
                cmbModulo.Items.Add("SIST");

            }
            else if (txtUsuario.Text == "Ceci")
            {
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("VTA");

            }
            else if (txtUsuario.Text == "God")
            {
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("SIST");
                cmbModulo.Items.Add("COM");
                cmbModulo.Items.Add("VTA");

            }
            else
            {

                cmbModulo.SelectedIndex = -1;
            }
        }

        private void cmbModulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbModulo.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" && txtContrasenia.Text == "@1a") ||
              (txtUsuario.Text == "John" && txtContrasenia.Text == "*2b") ||
              (txtUsuario.Text == "Ceci" && txtContrasenia.Text == "*@3c") ||
              (txtUsuario.Text == "God" && txtContrasenia.Text == "*@#4d"))
            {
                this.Hide(); // oculta este formualrio
                MessageBox.Show("Bienvenido/a " + txtUsuario.Text + ". Que tengas un maravilloso día.");
                frmInicio f = new frmInicio(); // crea el frmInicio
                f.Text = txtUsuario.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
                Close();


            }
            else
            {

                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                cmbModulo.SelectedIndex = -1;
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                i++;
                if (i == 3) // Si el numero de intentos fallidos es 3 se cierra automaticamente
                {
                    this.Close();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
