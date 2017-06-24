using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
namespace Estandar
{
    public partial class RegistrarPago : Form
    {

        private Solicitud solicitud;

        
        public RegistrarPago(Solicitud solicitud)
        {
            InitializeComponent();
            this.solicitud = solicitud;
            cargarDatos();
        }


        private void cargarDatos()
        {
            txtCodigoAlumno.Text = solicitud.codigoAlumnoSol;
            txtCodigoSolicitud.Text = solicitud.codigo;
            txtFechaEmision.Text = solicitud.fechaEmision.ToShortDateString();
            txtNombreCompleto.Text = solicitud.nombreSol + " " + solicitud.apellidosSol;
            txtNombreTesis.Text = solicitud.nombreTesis;
            txtObservacionesSolicitud.Text = solicitud.observaciones;
            txtDocumentoAlumno.Text = solicitud.numeroDocumentoSol;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
