using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace Estandar
{
    public partial class GenerarSolicitud : Form
    {
        private Alumno alumno;
        private IGestionTesis gestionTesis;
        
        public GenerarSolicitud()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            alumno = new Alumno();
            txtCodigo.KeyDown += new KeyEventHandler(txtCodigo_KeyDown);
        }

        void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Alumno busqueda = gestionTesis.buscarPorCodigo(txtCodigo.Text);
                if (busqueda == null)
                {
                    MessageBox.Show("No se encontro el alumno con codigo " + txtCodigo.Text);
                    limpiarDatosAlumno();
                }
                else
                {
                    this.alumno = busqueda;
                    cargarDatosAlumnos(alumno);
                }
            }
        }

        private void limpiarDatosAlumno()
        {
            txtCodigo.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtProgramaPosGrado.Text = "";
            txtNumeroDocumento.Text = "";
            txtDocumento.Text = "";
            txtGradoAcademico.Text = "";
            alumno = new Alumno();
        }

        private void cargarDatosAlumnos(Alumno alumno)
        {
            txtCodigo.Text = alumno.codigo;
            txtApellidos.Text = alumno.apellidos;
            txtNombres.Text = alumno.nombre;
            txtProgramaPosGrado.Text = alumno.programaPostGrado.nombrePrograma;
            txtNumeroDocumento.Text = alumno.numeroDocumento;
            txtDocumento.Text = alumno.tipoDocumento;
            txtGradoAcademico.Text = alumno.gradoAcademico;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerarSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAlumno form = new BuscarAlumno();
            var resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (form.obtenerAlumnoSeleccionado() != null)
                {
                    cargarDatosAlumnos(form.obtenerAlumnoSeleccionado());
                }
            }
        }
    }
}
