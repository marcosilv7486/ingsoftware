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
            listView1.DoubleClick += new EventHandler(listView1_DoubleClick);
        }

        void listView1_DoubleClick(object sender, EventArgs e)
        {
            int idSolicitud = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Solicitud solicitud = data.Find(p => p.id.Equals(idSolicitud));
            RegistrarPago form = new RegistrarPago(solicitud);
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                cargarData();
            }
        }

       
        private void SolicitudPendientePago_Load(object sender, EventArgs e)
        {
            data = new List<Solicitud>();
            gestionTesis = new GestionTesis();
            cargarData();
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
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
            listView1.Items.Clear();
            data = gestionTesis.obtenerSolicitudesPendientesPago();
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
            listitem.SubItems.Add(solicitud.nombreSol + " "+ solicitud.apellidosSol);
            listitem.SubItems.Add(solicitud.numeroDocumentoSol);
            listitem.SubItems.Add(solicitud.nombreTesis);
            listitem.SubItems.Add(solicitud.programaPostGrado);
            listitem.SubItems.Add(solicitud.nombreEstado);
            return listitem;
        }
    }
}
