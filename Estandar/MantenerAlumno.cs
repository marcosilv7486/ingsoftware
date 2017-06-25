using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using  Dominio;
using Negocio;
namespace Estandar
{
    public partial class MantenerAlumno : Form
    {

        private IGestionTesis gestionTesis;

        public MantenerAlumno()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
        }

        private void MantenerAlumno_Load(object sender, EventArgs e)
        {
            dtDatos.DataSource = gestionTesis.obtenerTodos().Tables[0];
        }
    }
}
