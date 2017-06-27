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
    public partial class EvaluarSolicitud : Form
    {

        private Solicitud solicitud;
        private IGestionTesis gestionTesis;
        
        public EvaluarSolicitud()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarSolicitud form = new BuscarSolicitud(3);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) 
            {
                solicitud = form.solicitud;
                cargarData(solicitud);
            }
        }

        private void cargarData(Solicitud solicitud)
        {
            txtCodigoAlumno.Text = solicitud.codigoAlumnoSol;
            txtCodigoSolicitud.Text = solicitud.codigo;
            txtFechaEmision.Text = solicitud.fechaEmision.ToShortDateString();
            txtNombreCompleto.Text = solicitud.nombreSol + " " + solicitud.apellidosSol;
            txtNombreTesis.Text = solicitud.nombreTesis;
            txtObservacionesSolicitud.Text = solicitud.observaciones;
            txtDocumentoAlumno.Text = solicitud.numeroDocumentoSol;
            foreach (SolicitudTema tema in solicitud.temas)
            {
                listBoxTemas.Items.Add(tema.tema.nombre);
            }
            if (!solicitud.alumno.urlFoto.Equals(""))
            {
                pbFoto.ImageLocation = Utilitario.getInstance().directorioFotos + solicitud.alumno.urlFoto;
            }
           
        }

        private void EvaluarSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCodigoSolicitud.Text))
            {
                MessageBox.Show("Debe seleccionar una solicitud a evaluar");
                return;
            }
            if (!radioAprobado.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Debe indicar el estado de la evaluacion");
                return;
            }
            if(String.IsNullOrEmpty(txtMotivoEvaluacion.Text))
            {
                MessageBox.Show("Debe ingresar el motivo por el cual aprueba/desaprueba la solicitud");
                return;
            }
            try
            {
                solicitud.motivoEvaluacion = txtMotivoEvaluacion.Text;
                solicitud.aprobado = radioAprobado.Checked;
                gestionTesis.registrarEvaluacionSolicitud(solicitud);
                MessageBox.Show("Se evaluo correctamente la solicitud , el codigo es "+solicitud.codigo
                        ,"Operacion correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void limpiar()
        {
            txtCodigoAlumno.Text = "";
            txtCodigoSolicitud.Text = "";
            txtFechaEmision.Text = "";
            txtNombreCompleto.Text = "";
            txtNombreTesis.Text = "";
            txtObservacionesSolicitud.Text = "";
            txtDocumentoAlumno.Text = "";
            listBoxTemas.Items.Clear();
            pbFoto.ImageLocation = "";
            txtMotivoEvaluacion.Text = "";
            radioAprobado.Checked = false;
            radioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
