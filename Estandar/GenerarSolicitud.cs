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
using System.IO;
namespace Estandar
{
    public partial class GenerarSolicitud : Form
    {
        private Alumno alumno;
        private IGestionTesis gestionTesis;
        private Solicitud solicitud;
        private List<TemaTesis> temasTesis;
        private String fotoPorDefecto;
        
        public GenerarSolicitud()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            alumno = new Alumno();
            solicitud = new Solicitud();
            cargarTesis();
            txtCodigo.KeyDown += new KeyEventHandler(txtCodigo_KeyDown);
        }

        private void cargarTesis()
        {
            temasTesis = gestionTesis.obtenerTesisHabilitadas();
            foreach(TemaTesis tesis in temasTesis)
            {
                listBoxTemas.Items.Add(tesis);
            }
        }

        void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Alumno busqueda = gestionTesis.buscarPorCodigo(txtCodigo.Text);
                if (busqueda == null)
                {
                    MessageBox.Show("No se encontro el alumno con codigo " + txtCodigo.Text);
                    limpiarData();
                }
                else
                {
                    this.alumno = busqueda;
                    cargarDatosAlumnos(alumno);
                }
            }
        }

        private void limpiarData()
        {
            alumno = new Alumno();
            solicitud = new Solicitud();
            txtCodigo.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtProgramaPosGrado.Text = "";
            txtNumeroDocumento.Text = "";
            txtDocumento.Text = "";
            txtGradoAcademico.Text = "";
            txtObservaciones.Text = "";
            txtNombreTesis.Text = "";
            listBoxTemas.ClearSelected();
            foreach (int i in listBoxTemas.CheckedIndices)
            {
                listBoxTemas.SetItemCheckState(i, CheckState.Unchecked);
            }
            pbFoto.ImageLocation = fotoPorDefecto;
            pbFoto.Refresh();
           
        }

        private void cargarDatosAlumnos(Alumno alumno)
        {
            this.alumno = alumno;
            txtCodigo.Text = alumno.codigo;
            txtApellidos.Text = alumno.apellidos;
            txtNombres.Text = alumno.nombre;
            txtProgramaPosGrado.Text = alumno.programaPostGrado.nombrePrograma;
            txtNumeroDocumento.Text = alumno.numeroDocumento;
            txtDocumento.Text = alumno.tipoDocumento;
            txtGradoAcademico.Text = alumno.gradoAcademico;
            if (!alumno.urlFoto.Equals(""))
            {
                pbFoto.ImageLocation = Utilitario.getInstance().directorioFotos+alumno.urlFoto;
            }
            else
            {
                pbFoto.ImageLocation = fotoPorDefecto;
            }
        }

        private Solicitud generarSolicitud()
        {
            Solicitud solicitud = new Solicitud();
            if (alumno.id==0)
            {
                MessageBox.Show("Debe seleccionar primero un alumno ");
                return null;
            }
            if (txtNombreTesis.Text == String.Empty || txtNombreTesis.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar escribir el nombre de la tesis ");
                return null;
            }
            if (listBoxTemas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos un tema de la tesis");
                return null;
            }
            solicitud.alumno = alumno;
            solicitud.fechaEmision = dtFechaSolicitud.Value;
            solicitud.observaciones = txtObservaciones.Text;
            solicitud.nombreTesis = txtNombreTesis.Text;
            solicitud.codigoAlumnoSol = alumno.codigo;
            solicitud.nombreSol = alumno.nombre;
            solicitud.apellidosSol = alumno.apellidos;
            solicitud.programaPostGrado = alumno.programaPostGrado.nombrePrograma;
            solicitud.numeroDocumentoSol = alumno.numeroDocumento;
            solicitud.tipoDocumentoSol = alumno.tipoDocumento;
            solicitud.gradoAcademicoSol = alumno.gradoAcademico;
            foreach (object obj in listBoxTemas.CheckedItems)
            {
                TemaTesis tesis = (TemaTesis)obj;
                SolicitudTema solicitudTema = new SolicitudTema();
                solicitudTema.tema = tesis;
                solicitudTema.solicitud = solicitud;
                solicitud.temas.Add(solicitudTema);
            }

            return solicitud;
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
            fotoPorDefecto = pbFoto.ImageLocation;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = generarSolicitud();
            if (solicitud != null)
            {
                try
                {
                    gestionTesis.registrarSolicitud(solicitud);
                    MessageBox.Show("Se registro correctamente la solicitud , el codigo es "+solicitud.codigo
                        ,"Operacion correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiarData();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ocurrio Un error ");
                    MessageBox.Show(exp.Message);
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarData();
        }
    }
}
