using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private async void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Ingrese un código de usuario");
                CodigoUsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClavetextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ClavetextBox, "Ingrese una clave");
                ClavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();


            bool valido = await userDatos.LoginAsync(CodigoUsuariotextBox.Text, ClavetextBox.Text);

            if (valido)
            {
                Menu Formulario = new Menu();
                Hide();
                Formulario.Show();

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
