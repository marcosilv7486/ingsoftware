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
        private Alumno alumno;
        
        public BuscarAlumno()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
            listView1.View = View.Details;
            cargarDatos();
            listView1.DoubleClick += new EventHandler(listView1_DoubleClick);

        }

        void listView1_DoubleClick(object sender, EventArgs e)
        {
            int idSeleccionado = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            alumno = alumnos.Find(a => a.id.Equals(idSeleccionado));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cargarDatos()
        {
            alumnos = gestionTesis.obtenerAlumnosHabilitados();
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem listitem = new ListViewItem(alumno.id.ToString());
                listitem.SubItems.Add(alumno.codigo);
                listitem.SubItems.Add(alumno.nombre);
                listitem.SubItems.Add(alumno.apellidos);
                listitem.SubItems.Add(alumno.tipoDocumento);
                listitem.SubItems.Add(alumno.numeroDocumento);
                listitem.SubItems.Add(alumno.programaPostGrado.nombrePrograma);
                listitem.SubItems.Add(alumno.planCurricular);
                listView1.Items.Add(listitem);
                
            }
        }

        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Alumno obtenerAlumnoSeleccionado()
        {
            return alumno;
        }
    }
}
