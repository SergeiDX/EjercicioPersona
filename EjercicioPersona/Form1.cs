using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Contacto oContacto = new Contacto();
            string RFC = oContacto.Extraccion(txtApPaterno.Text,txtApMaterno.Text,txtNombre.Text,txtFecNac.Text);
            txtResul.Text = RFC;

        }

        private void txtFecNac_Click(object sender, EventArgs e)
        {
            txtFecNac.Text = "";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtResul.Clear();
            txtTel.Clear();
            txtEmail.Clear();
        }
    }

}
