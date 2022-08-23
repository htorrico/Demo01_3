using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo01_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {

            string mensaje = txtNombre.Text + " " + txtApellido.Text;

            MessageBox.Show("Bienvenido " + mensaje);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add()
        }
    }
}
