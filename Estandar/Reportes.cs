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
        
        public Reportes()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            data = new List<Solicitud>();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_TESISDataSet.SOLICITUD' table. You can move, or remove it, as needed.
            this.SOLICITUDTableAdapter.Fill(this.BD_TESISDataSet.SOLICITUD);
            // TODO: This line of code loads data into the 'MIEMBROS_HORARIO.HORARIO_TESIS_POR_SOLICITUD' table. You can move, or remove it, as needed.
            this.HORARIO_TESIS_POR_SOLICITUDTableAdapter.Fill(this.MIEMBROS_HORARIO.HORARIO_TESIS_POR_SOLICITUD,1);
            // TODO: This line of code loads data into the 'BD_TESISDataSet.SOLICITUD' table. You can move, or remove it, as needed.
            this.SOLICITUDTableAdapter.FillBy(this.BD_TESISDataSet.SOLICITUD,1);

            this.reportViewer1.RefreshReport();
        }
    }
}
