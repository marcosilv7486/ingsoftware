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
    public partial class SolicitudPendientePago : Form
    {

        private List<Solicitud> data;
        private IGestionTesis gestionTesis;
        
        public SolicitudPendientePago()
        {
            InitializeComponent();
            dtListado.CellDoubleClick += new DataGridViewCellEventHandler(dtListado_CellDoubleClick);
        }

        void dtListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int idSolicitud = int.Parse(dtListado.Rows[e.RowIndex].Cells[0].Value.ToString());
            Solicitud solicitud = data.Find(p => p.id.Equals(idSolicitud));
            RegistrarPago form = new RegistrarPago(solicitud);
            form.ShowDialog();
        }

        private void SolicitudPendientePago_Load(object sender, EventArgs e)
        {
            data = new List<Solicitud>();
            gestionTesis = new GestionTesis();
            cargarData();
        }

        private void cargarData()
        {
            data = gestionTesis.obtenerSolicitudesPendientesPago();
            if (data.Count == 0)
            {
                MessageBox.Show("No se encontraron solicitudes pendientes");
            }
            else 
            {
                //this.dtListado.DataSource = data;
                foreach (Solicitud solicitud in data)
                {
                    this.dtListado.Rows.Add(
                        solicitud.id.ToString(),
                        solicitud.codigo,
                        solicitud.fechaEmision.ToShortDateString(),
                        solicitud.codigoAlumnoSol,
                        solicitud.nombreSol,
                        solicitud.apellidosSol,
                        solicitud.numeroDocumentoSol,
                        solicitud.nombreTesis,
                        solicitud.programaPostGrado,
                        solicitud.nombreEstado);
                }
            }
        }
    }
}
