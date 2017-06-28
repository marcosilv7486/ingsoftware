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
    public partial class SolicitudesFinalizadas : Form
    {

        private List<Solicitud> data;
        private IGestionTesis gestionTesis;
        public Solicitud solicitud { get; set; }
        public SolicitudesFinalizadas()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SolicitudesFinalizadas_Load(object sender, EventArgs e)
        {
            listView1.DoubleClick += new EventHandler(listView1_DoubleClick);
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
            cargarData();
        }

        void listView1_DoubleClick(object sender, EventArgs e)
        {
            int idSolicitud = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Solicitud solicitud = data.Find(p => p.id.Equals(idSolicitud));
            this.solicitud = solicitud;
            Reportes reporte = new Reportes(idSolicitud);
            reporte.ShowDialog();
        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(data.Where(i => string.IsNullOrEmpty(txtNombre.Text) || i.nombreCompleto().ToLower().Contains(txtNombre.Text.ToLower()))
            .Select(c => generarSolicitud(c)).ToArray());
        }

        void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(data.Where(i => string.IsNullOrEmpty(txtCodigo.Text) || i.codigoAlumnoSol.ToLower().StartsWith(txtCodigo.Text.ToLower()))
            .Select(c => generarSolicitud(c)).ToArray());
        }

        private void cargarData()
        {
            data = gestionTesis.obtenerSolicitudPorEstado(6);
            foreach (Solicitud solicitud in data)
            {
                listView1.Items.Add(generarSolicitud(solicitud));
            }
        }

        private ListViewItem generarSolicitud(Solicitud solicitud)
        {
            ListViewItem listitem = new ListViewItem(solicitud.id.ToString());
            listitem.SubItems.Add(solicitud.codigo);
            listitem.SubItems.Add(solicitud.fechaEmision.ToShortDateString());
            listitem.SubItems.Add(solicitud.codigoAlumnoSol);
            listitem.SubItems.Add(solicitud.nombreSol + " " + solicitud.apellidosSol);
            listitem.SubItems.Add(solicitud.numeroDocumentoSol);
            listitem.SubItems.Add(solicitud.nombreTesis);
            listitem.SubItems.Add(solicitud.programaPostGrado);
            listitem.SubItems.Add(solicitud.nombreEstado);
            return listitem;
        }
    }
}
