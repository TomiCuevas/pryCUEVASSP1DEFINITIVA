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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPERAMOS QUE TENGA UNA BUENA EXPERIENCIA. PARA MÁS CONSULTAS A: info@belgranoesdeprimera.com");
            Close();
        }
    }
}
