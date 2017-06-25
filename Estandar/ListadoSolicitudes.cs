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
    public partial class ListadoSolicitudes : Form
    {

        private IGestionTesis gestionTesis;
        private List<Solicitud> data;

        public ListadoSolicitudes()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            cargarData(1);
        }

        private void ListadoSolicitudes_Load(object sender, EventArgs e)
        {
            tabEstados.SelectedIndexChanged += new EventHandler(tabEstados_SelectedIndexChanged);
        }

        void tabEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(tabEstados.SelectedTab.Name.Replace("tab", ""));
            cargarData(id);
        }

        private void cargarData(int idEstado)
        {
            data = gestionTesis.obtenerSolicitudPorEstado(idEstado);
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
        }
         
    }
}
