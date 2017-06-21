using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;
namespace Estandar
{
    public partial class BuscarAlumno : Form
    {

        private IGestionTesis gestionTesis;
        private List<Alumno> alumnos;
        
        public BuscarAlumno()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            listView1.View = View.Details;
            cargarDatos();
        }

        private void cargarDatos()
        {
            alumnos = gestionTesis.obtenerAlumnosHabilitados();
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem listitem = new ListViewItem(alumno.ToString());
                listitem.SubItems.Add(alumno.nombre);
                listView1.Items.Add(listitem);
            }
        }

        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
