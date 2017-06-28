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
        private String usuario = "admin";
        private String clave = "123456";
        
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

        private void validarLogin()
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Debe ingresar el usuario", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (txtPwd.Text.Equals(clave) && txtUserName.Text.Equals(usuario))
            {
                credencialesCorrectos = true;
                Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarLogin();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPwd.KeyPress += new KeyPressEventHandler(txtPwd_KeyPress);
            txtPwd.KeyDown += new KeyEventHandler(txtPwd_KeyDown);
        }

        void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validarLogin();
            }
        }

        void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
