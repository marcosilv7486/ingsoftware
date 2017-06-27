﻿using System;
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
        public Profesor profesor {get;set;}
        
        public BuscarProfesor()
        {
            InitializeComponent();
            tesis = new GestionTesis();
        }

        private void BuscarProfesor_Load(object sender, EventArgs e)
        {
            cargarData();
            txtCodigo.KeyUp += new KeyEventHandler(txtCodigo_KeyUp);
            txtNombre.KeyUp += new KeyEventHandler(txtNombre_KeyUp);
            txtMaestria.KeyUp += new KeyEventHandler(txtMaestria_KeyUp);
        }

        void txtMaestria_KeyUp(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(lista.Where(i => string.IsNullOrEmpty(txtMaestria.Text) || i.maestria.ToLower().Contains(txtMaestria.Text.ToLower()))
            .Select(c => generarProfesor(c)).ToArray());
        }

        void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(lista.Where(i => string.IsNullOrEmpty(txtNombre.Text) || i.nombreCompleto().ToLower().Contains(txtNombre.Text.ToLower()))
            .Select(c => generarProfesor(c)).ToArray());
        }

        void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(lista.Where(i => string.IsNullOrEmpty(txtCodigo.Text) || i.codigo.ToLower().StartsWith(txtCodigo.Text.ToLower()))
            .Select(c => generarProfesor(c)).ToArray());
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
            listitem.SubItems.Add(profesor.observaciones);
            return listitem;
        }
    }
}