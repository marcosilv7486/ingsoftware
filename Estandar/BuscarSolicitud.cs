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
    public partial class BuscarSolicitud : Form
    {
        private List<Solicitud> data;
        private IGestionTesis gestionTesis;
        private int idEstado;
        public Solicitud solicitud {get;set;}

        public BuscarSolicitud(int idEstado)
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            this.idEstado = idEstado;
        }

        private void BuscarSolicitud_Load(object sender, EventArgs e)
        {
            data = gestionTesis.obtenerSolicitudPorEstado(this.idEstado);
            dtListado.Rows.Clear();
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
            dtListado.CellDoubleClick += new DataGridViewCellEventHandler(dtListado_CellDoubleClick);
        }

        void dtListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Solicitud solicitud = data.Find(p => p.id.Equals(int.Parse(dtListado.Rows[e.RowIndex].Cells[0].Value.ToString())));
            this.solicitud = solicitud;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
