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
    public partial class BuscarProfesor : Form
    {
        public IGestionTesis tesis;
        private List<Profesor> lista;
        
        public BuscarProfesor()
        {
            InitializeComponent();
            tesis = new GestionTesis();
        }

        private void BuscarProfesor_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            lista = tesis.obtenerProfesoresHabilitados();
            foreach (Profesor profesor in lista)
            {

                listView1.Items.Add(generarProfesor(profesor));

            }
        }

        private ListViewItem generarProfesor(Profesor profesor)
        {
            ListViewItem listitem = new ListViewItem(profesor.id.ToString());
            listitem.SubItems.Add(profesor.codigo);
            listitem.SubItems.Add(profesor.nombres);
            listitem.SubItems.Add(profesor.apellidos);
            listitem.SubItems.Add(profesor.maestria);
            listitem.SubItems.Add(profesor.doctorado);
            return listitem;
        }
    }
}
