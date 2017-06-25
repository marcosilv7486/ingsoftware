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
    public partial class RegistrarPago : Form
    {

        private Solicitud solicitud;

        private IGestionTesis gestionTesis;
        private List<FormaDePago> listaFormaPago;
        
        public RegistrarPago(Solicitud solicitud)
        {
            InitializeComponent();
            this.solicitud = solicitud;
            cargarDatos();
            gestionTesis = new GestionTesis();
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

     

        private void RegistrarPago_Load_1(object sender, EventArgs e)
        {
            listaFormaPago = gestionTesis.obtenerFormasPagoHabilitadas();
            cboFormaPago.DataSource = listaFormaPago;
            cboFormaPago.DisplayMember = "nombre";
            cboFormaPago.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagoSolicitud pago = new PagoSolicitud();
            pago.solicitud = solicitud;
            pago.fechaPago = dtFechaPago.Value;
            pago.monto = Decimal.Parse(txtSaldoAmortizado.Text);
            pago.serie = txtSerie.Text;
            pago.numero = txtNumero.Text;
            pago.fotoAdjunta = txtRutaArchivo.Text;
            FormaDePago formaSeleccionada = listaFormaPago
                .Find(p => p.id.Equals(int.Parse(cboFormaPago.SelectedValue.ToString())));
            pago.formaDePago = formaSeleccionada;
            gestionTesis.registrarPagoSolicitud(pago);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Seleccione un archivo";
                dlg.Filter = "Archivo de Texto (*.txt)|*.pdf;*.txt;*.docx;*.doc";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRutaArchivo.Text=dlg.FileName;
                }
            }
        }
    }
}
