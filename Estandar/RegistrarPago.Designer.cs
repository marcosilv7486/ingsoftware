namespace Estandar
{
    partial class RegistrarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPago));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSaldoAmortizado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Pago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la solicitud";
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.groupBox2.Controls.Add(this.txtRutaArchivo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtSaldoAmortizado);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFechaPago);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboFormaPago);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Pago";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(284, 118);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(416, 20);
            this.txtRutaArchivo.TabIndex = 28;
            this.txtRutaArchivo.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(116, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar archivo...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Documento Adjunto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 24;
            // 
            // txtSaldoAmortizado
            // 
            this.txtSaldoAmortizado.Location = new System.Drawing.Point(416, 67);
            this.txtSaldoAmortizado.Name = "txtSaldoAmortizado";
            this.txtSaldoAmortizado.Size = new System.Drawing.Size(142, 20);
            this.txtSaldoAmortizado.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Saldo A Pagar";
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Location = new System.Drawing.Point(98, 67);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(142, 20);
            this.dtFechaPago.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fecha de Pago:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(463, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(95, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Número:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(321, 32);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(69, 20);
            this.txtSerie.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Serie:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(97, 32);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(143, 21);
            this.cboFormaPago.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Forma de Pago:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarPago";
            this.Text = "Registrar Pago";
            this.Load += new System.EventHandler(this.RegistrarPago_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.TextBox txtCodigoSolicitud;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacionesSolicitud;
        private System.Windows.Forms.TextBox txtNombreTesis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSaldoAmortizado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button button2;
    }
}