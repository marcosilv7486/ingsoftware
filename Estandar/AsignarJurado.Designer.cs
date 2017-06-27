namespace Estandar
{
    partial class AsignarJurado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarJurado));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotivoAprobacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfechaAprobacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxTemas = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtObservacionesSolicitud = new System.Windows.Forms.TextBox();
            this.txtNombreTesis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumentoAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaEmision = new System.Windows.Forms.TextBox();
            this.txtCodigoSolicitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboHoras = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataJurado = new System.Windows.Forms.DataGridView();
            this.Remover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CodigoProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompletoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresidenteJurado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJurado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asignar Jurado y Miembros";
            // 
            // button1
            // 
            this.button1.Image = global::Estandar.Properties.Resources._1498299142_system_search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar Solicitud Aprobada";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotivoAprobacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtfechaAprobacion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listBoxTemas);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtObservacionesSolicitud);
            this.groupBox1.Controls.Add(this.txtNombreTesis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDocumentoAlumno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCodigoAlumno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFechaEmision);
            this.groupBox1.Controls.Add(this.txtCodigoSolicitud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 315);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la solicitud";
            // 
            // txtMotivoAprobacion
            // 
            this.txtMotivoAprobacion.Enabled = false;
            this.txtMotivoAprobacion.Location = new System.Drawing.Point(163, 266);
            this.txtMotivoAprobacion.Multiline = true;
            this.txtMotivoAprobacion.Name = "txtMotivoAprobacion";
            this.txtMotivoAprobacion.Size = new System.Drawing.Size(528, 42);
            this.txtMotivoAprobacion.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Motivo de Aprobacion:";
            // 
            // txtfechaAprobacion
            // 
            this.txtfechaAprobacion.Enabled = false;
            this.txtfechaAprobacion.Location = new System.Drawing.Point(163, 240);
            this.txtfechaAprobacion.Name = "txtfechaAprobacion";
            this.txtfechaAprobacion.Size = new System.Drawing.Size(145, 20);
            this.txtfechaAprobacion.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha de Aprobacion:";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Estandar.Properties.Resources.id_card_3;
            this.pbFoto.Location = new System.Drawing.Point(578, 29);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(113, 131);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 17;
            this.pbFoto.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Temas:";
            // 
            // listBoxTemas
            // 
            this.listBoxTemas.FormattingEnabled = true;
            this.listBoxTemas.Location = new System.Drawing.Point(163, 178);
            this.listBoxTemas.Name = "listBoxTemas";
            this.listBoxTemas.Size = new System.Drawing.Size(395, 56);
            this.listBoxTemas.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Image = global::Estandar.Properties.Resources.file1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(578, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Descargar Tesis";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtObservacionesSolicitud
            // 
            this.txtObservacionesSolicitud.Enabled = false;
            this.txtObservacionesSolicitud.Location = new System.Drawing.Point(163, 147);
            this.txtObservacionesSolicitud.Name = "txtObservacionesSolicitud";
            this.txtObservacionesSolicitud.Size = new System.Drawing.Size(395, 20);
            this.txtObservacionesSolicitud.TabIndex = 13;
            // 
            // txtNombreTesis
            // 
            this.txtNombreTesis.Enabled = false;
            this.txtNombreTesis.Location = new System.Drawing.Point(163, 118);
            this.txtNombreTesis.Name = "txtNombreTesis";
            this.txtNombreTesis.Size = new System.Drawing.Size(395, 20);
            this.txtNombreTesis.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observaciones solicitud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre Tesis:";
            // 
            // txtDocumentoAlumno
            // 
            this.txtDocumentoAlumno.Enabled = false;
            this.txtDocumentoAlumno.Location = new System.Drawing.Point(413, 60);
            this.txtDocumentoAlumno.Name = "txtDocumentoAlumno";
            this.txtDocumentoAlumno.Size = new System.Drawing.Size(145, 20);
            this.txtDocumentoAlumno.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Documento Alumno:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Enabled = false;
            this.txtCodigoAlumno.Location = new System.Drawing.Point(95, 63);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(145, 20);
            this.txtCodigoAlumno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código Alumno:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(163, 92);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(395, 20);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Completo Alumno:";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Enabled = false;
            this.txtFechaEmision.Location = new System.Drawing.Point(413, 29);
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.Size = new System.Drawing.Size(145, 20);
            this.txtFechaEmision.TabIndex = 3;
            // 
            // txtCodigoSolicitud
            // 
            this.txtCodigoSolicitud.Enabled = false;
            this.txtCodigoSolicitud.Location = new System.Drawing.Point(95, 29);
            this.txtCodigoSolicitud.Name = "txtCodigoSolicitud";
            this.txtCodigoSolicitud.Size = new System.Drawing.Size(145, 20);
            this.txtCodigoSolicitud.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Emisión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código Solicitud:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaInicio);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dataJurado);
            this.groupBox2.Controls.Add(this.cboHoras);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtHoraInicio);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtLugar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 261);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Miembros del Jurado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cboHoras
            // 
            this.cboHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoras.FormattingEnabled = true;
            this.cboHoras.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboHoras.Location = new System.Drawing.Point(543, 93);
            this.cboHoras.Name = "cboHoras";
            this.cboHoras.Size = new System.Drawing.Size(121, 21);
            this.cboHoras.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Duracion (horas):";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraInicio.Location = new System.Drawing.Point(312, 92);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(87, 20);
            this.txtHoraInicio.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Fecha de Inicio:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(68, 60);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(623, 20);
            this.txtLugar.TabIndex = 20;
            this.txtLugar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Lugar:";
            // 
            // button3
            // 
            this.button3.Image = global::Estandar.Properties.Resources._1498299142_system_search;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Agregar Miembros de Jurado";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataJurado
            // 
            this.dataJurado.AllowUserToAddRows = false;
            this.dataJurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJurado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remover,
            this.CodigoProfesor,
            this.NombreCompletoDocente,
            this.PresidenteJurado});
            this.dataJurado.Location = new System.Drawing.Point(3, 118);
            this.dataJurado.Name = "dataJurado";
            this.dataJurado.ReadOnly = true;
            this.dataJurado.Size = new System.Drawing.Size(688, 137);
            this.dataJurado.TabIndex = 25;
            this.dataJurado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataJurado_CellContentClick);
            // 
            // Remover
            // 
            this.Remover.HeaderText = "Remover";
            this.Remover.Name = "Remover";
            this.Remover.ReadOnly = true;
            this.Remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remover.Text = "";
            this.Remover.Width = 75;
            // 
            // CodigoProfesor
            // 
            this.CodigoProfesor.HeaderText = "Cod Docente";
            this.CodigoProfesor.Name = "CodigoProfesor";
            this.CodigoProfesor.ReadOnly = true;
            // 
            // NombreCompletoDocente
            // 
            this.NombreCompletoDocente.HeaderText = "Nombre Completo Profesor";
            this.NombreCompletoDocente.Name = "NombreCompletoDocente";
            this.NombreCompletoDocente.ReadOnly = true;
            this.NombreCompletoDocente.Width = 300;
            // 
            // PresidenteJurado
            // 
            this.PresidenteJurado.HeaderText = "Presidente de Jurado ?";
            this.PresidenteJurado.Name = "PresidenteJurado";
            this.PresidenteJurado.ReadOnly = true;
            this.PresidenteJurado.Width = 170;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(176, 652);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 31);
            this.button4.TabIndex = 20;
            this.button4.Text = "Cerrar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(102, 652);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 31);
            this.button5.TabIndex = 19;
            this.button5.Text = "Limpiar";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 652);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "Guardar";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(218, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Hora de Inicio:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(104, 92);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(87, 20);
            this.txtFechaInicio.TabIndex = 27;
            // 
            // AsignarJurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 686);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AsignarJurado";
            this.Text = "Asignar Jurado de Tesis";
            this.Load += new System.EventHandler(this.AsignarJurado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJurado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotivoAprobacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfechaAprobacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxTemas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtObservacionesSolicitud;
        private System.Windows.Forms.TextBox txtNombreTesis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumentoAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.TextBox txtCodigoSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtHoraInicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboHoras;
        private System.Windows.Forms.DataGridView dataJurado;
        private System.Windows.Forms.DataGridViewLinkColumn Remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoDocente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PresidenteJurado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.Label label15;
    }
}