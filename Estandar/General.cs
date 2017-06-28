using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estandar
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender,  EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ListadoSolicitudes form = new ListadoSolicitudes();
            form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            EvaluarSolicitud form = new EvaluarSolicitud();
            form.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GenerarSolicitud form = new GenerarSolicitud();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MantenerProfesor form = new MantenerProfesor();
            form.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SolicitudPendientePago form = new SolicitudPendientePago();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MantenerAlumno form = new MantenerAlumno();
            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AsignarJurado form = new AsignarJurado();
            form.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SolicitudesFinalizadas form = new SolicitudesFinalizadas();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muy pronto !!!");
        }
    }
}
