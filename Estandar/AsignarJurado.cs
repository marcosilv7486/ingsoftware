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
    public partial class AsignarJurado : Form
    {
        private Solicitud solicitud;
        private List<HorarioSustentacion> horarios;
        private IGestionTesis gestionTesis;
        public AsignarJurado()
        {
            InitializeComponent();
            gestionTesis = new GestionTesis();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarSolicitud form = new BuscarSolicitud(5);
            horarios = new List<HorarioSustentacion>();
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                solicitud = form.solicitud;
                cargarData(solicitud);
            }
        }

        private void cargarData(Solicitud solicitud)
        {
            txtCodigoAlumno.Text = solicitud.codigoAlumnoSol;
            txtCodigoSolicitud.Text = solicitud.codigo;
            txtFechaEmision.Text = solicitud.fechaEmision.ToShortDateString();
            txtNombreCompleto.Text = solicitud.nombreSol + " " + solicitud.apellidosSol;
            txtNombreTesis.Text = solicitud.nombreTesis;
            txtObservacionesSolicitud.Text = solicitud.observaciones;
            txtDocumentoAlumno.Text = solicitud.numeroDocumentoSol;
            txtfechaAprobacion.Text = solicitud.fechaEvaluacion.Value.ToString("dd/MM/yyyy HH:mm:ss");
            txtMotivoAprobacion.Text = solicitud.motivoEvaluacion;
            foreach (SolicitudTema tema in solicitud.temas)
            {
                listBoxTemas.Items.Add(tema.tema.nombre);
            }
            if (!solicitud.alumno.urlFoto.Equals(""))
            {
                pbFoto.ImageLocation = Utilitario.getInstance().directorioFotos + solicitud.alumno.urlFoto;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarProfesor form = new BuscarProfesor();
            if (String.IsNullOrEmpty(txtCodigoSolicitud.Text))
            {
                MessageBox.Show("Debe seleccionar primero una solicitud aprobada");
                return;
            }
            var result=form.ShowDialog();
            
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               
                Profesor profesor = form.profesor;
                bool profesorEnLista = horarios.Exists(p => p.profesor.codigo.Equals(profesor.codigo));
                if (profesorEnLista) 
                {
                    MessageBox.Show("El docente ya se encuentra agregado a la lista");
                    return;
                }
                var index = dataJurado.Rows.Add();
                dataJurado.Rows[index].Cells[0].Value = "Remover";
                dataJurado.Rows[index].Cells[1].Value = profesor.codigo;
                dataJurado.Rows[index].Cells[2].Value = profesor.nombreCompleto();
                dataJurado.Rows[index].Cells[3].Value = false;
                HorarioSustentacion horario = new HorarioSustentacion();
                horario.solicitud = solicitud;
                horario.profesor = profesor;
                horarios.Add(horario);
            }
        }

        private void AsignarJurado_Load(object sender, EventArgs e)
        {
            dataJurado.CellClick += new DataGridViewCellEventHandler(dataJurado_CellClick);
        }

        void dataJurado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataJurado.Columns["Remover"].Index)
            {
                DialogResult dr = MessageBox.Show("Esta seguro de remover el docente de la lista de jurados?", "Confirmacion de accion", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    String codigoAlumno = dataJurado.Rows[e.RowIndex].Cells[1].Value.ToString();
                    HorarioSustentacion profesorARemover = horarios.Find(p => p.profesor.codigo.Equals(codigoAlumno));
                    horarios.Remove(profesorARemover);
                    dataJurado.Rows.RemoveAt(e.RowIndex);    
                }
            }
            if (e.ColumnIndex == dataJurado.Columns["PresidenteJurado"].Index)
            {
                bool seleccionado=!Boolean.Parse(dataJurado.Rows[e.RowIndex].Cells[3].Value.ToString());
                dataJurado.Rows[e.RowIndex].Cells[3].Value = seleccionado;
                String codigoAlumno = dataJurado.Rows[e.RowIndex].Cells[1].Value.ToString();
                HorarioSustentacion profesorSeleccionado = horarios.Find(p => p.profesor.codigo.Equals(codigoAlumno));
                profesorSeleccionado.esPresidente = seleccionado;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataJurado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Validacion SOlicitud
            if (String.IsNullOrEmpty(txtCodigoSolicitud.Text))
            {
                MessageBox.Show("Debe seleccionar primero una solicitud aprobada");
                return;
            }
            //Validacion agregar docentes
            if (horarios.Count == 0)
            {
                MessageBox.Show("Debe agregar docentes para el jurado de tesis.");
                return;
            }
            //Validaciones un jefe de grupo
            List<HorarioSustentacion> dataFiltrada = horarios.Where(p => p.esPresidente).ToList<HorarioSustentacion>();
            if (dataFiltrada.Count==0)
            {
                MessageBox.Show("Debe seleccionar al jefe de jurado.");
                return;
            }
            //Validacion maximo 1 jefe de grupo
            if (dataFiltrada.Count > 1)
            {
                MessageBox.Show("Solo puede existir un jefe de jurado por grupo.");
                return;
            }
            if(String.IsNullOrEmpty(txtLugar.Text))
            {
                MessageBox.Show("Debe ingresar el lugar de la exposicion de la tesis");
                return;
            }
            if (String.IsNullOrEmpty(cboHoras.Text))
            {
                MessageBox.Show("Debe ingresar el numero de horas de la exposicion de tesis");
                return;
            }
            foreach (HorarioSustentacion horario in horarios)
            {
                horario.fecha = txtFechaInicio.Value.Date;
                horario.hora = txtHoraInicio.Value;
                horario.fechaFin = horario.fecha.AddHours(horario.hora.Hour).AddMinutes(horario.hora.Minute).AddHours(int.Parse(cboHoras.Text.ToString()));
                horario.lugar = txtLugar.Text;
                horario.duracion = int.Parse(cboHoras.Text.ToString());
            }
            try
            {
                gestionTesis.registrarMiembrosTesis(horarios);
                MessageBox.Show("Se registro correctamente la asignacion del jurado , Puede consultarlo en la opcion reportes. " + solicitud.codigo
                           , "Operacion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            solicitud = new Solicitud();
             txtCodigoAlumno.Text = "";
            txtCodigoSolicitud.Text = "";
            txtFechaEmision.Text = "";
            txtNombreCompleto.Text = "";
            txtNombreTesis.Text = "";
            txtObservacionesSolicitud.Text = "";
            txtDocumentoAlumno.Text = "";
            listBoxTemas.Items.Clear();
            pbFoto.ImageLocation = "";
            txtMotivoAprobacion.Text = "";
            listBoxTemas.Items.Clear();
            pbFoto.ImageLocation = "";
            horarios = new List<HorarioSustentacion>();
            dataJurado.Rows.Clear();
            txtfechaAprobacion.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
