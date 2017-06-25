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
           
        }

        private void EvaluarSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            solicitud.motivoDesaprobacion = txtMotivoEvaluacion.Text;
            solicitud.aprobado = radioAprobado.Checked;
            gestionTesis.registrarEvaluacionSolicitud(solicitud);
        }
    }
}
