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
    public partial class AsignarJurado : Form
    {
        private Solicitud solicitud;
        
        
        public AsignarJurado()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarSolicitud form = new BuscarSolicitud(5);
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
            txtfechaAprobacion.Text = solicitud.fechaEvaluacion.Value.ToString("dd/MM/yyyy HH:mm:ss");
            txtMotivoAprobacion.Text = solicitud.motivoEvaluacion;
            foreach (SolicitudTema tema in solicitud.temas)
            {
                listBoxTemas.Items.Add(tema.tema.nombre);
            }
            if (!solicitud.alumno.urlFoto.Equals(""))
            {
                pbFoto.ImageLocation = Utilitario.getInstance().directorioFotos + solicitud.alumno.urlFoto;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarProfesor form = new BuscarProfesor();
            form.ShowDialog();
        }

        private void AsignarJurado_Load(object sender, EventArgs e)
        {

        }
    }
}
