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
using Microsoft.Reporting.WinForms;
namespace Estandar
{
    public partial class Reportes : Form
    {
        private IGestionTesis gestionTesis;
        private List<Solicitud> data;
        private int idSolicitud;
        public Reportes(int idSolicitud)
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            data = new List<Solicitud>();
            this.idSolicitud = idSolicitud;
            this.FormClosing += new FormClosingEventHandler(Reportes_FormClosing);
        }

        void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_TESISDataSet.SOLICITUD' table. You can move, or remove it, as needed.
            this.SOLICITUDTableAdapter.Fill(this.BD_TESISDataSet.SOLICITUD);
            // TODO: This line of code loads data into the 'MIEMBROS_HORARIO.HORARIO_TESIS_POR_SOLICITUD' table. You can move, or remove it, as needed.
            this.HORARIO_TESIS_POR_SOLICITUDTableAdapter.Fill(this.MIEMBROS_HORARIO.HORARIO_TESIS_POR_SOLICITUD,idSolicitud);
            // TODO: This line of code loads data into the 'BD_TESISDataSet.SOLICITUD' table. You can move, or remove it, as needed.
            this.SOLICITUDTableAdapter.FillBy(this.BD_TESISDataSet.SOLICITUD,idSolicitud);

            this.reportViewer1.RefreshReport();
        }
    }
}
