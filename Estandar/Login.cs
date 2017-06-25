using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Estandar
{
    public partial class Login : Form

    {
        public bool credencialesCorrectos { get; set; }
        
        public Login()
        {
            InitializeComponent();
            credencialesCorrectos = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Debe ingresar el usuario", "Campos requeridos", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                MessageBox.Show(Directory.GetCurrentDirectory());
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            credencialesCorrectos = true;
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
