namespace Estandar
{
    partial class SolicitudPendientePago
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTesis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPosGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Solicitudes Pendientes por Pagar";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.FechaEmision,
            this.CodigoA,
            this.Nombre,
            this.Apellidos,
            this.NumeroDocumento,
            this.NombreTesis,
            this.PPosGrado,
            this.Estado});
            this.dtListado.Location = new System.Drawing.Point(12, 75);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(945, 336);
            this.dtListado.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "F.Emision";
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.ReadOnly = true;
            // 
            // CodigoA
            // 
            this.CodigoA.HeaderText = "Codigo A.";
            this.CodigoA.Name = "CodigoA";
            this.CodigoA.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "N.Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // NombreTesis
            // 
            this.NombreTesis.HeaderText = "Nombre de Tesis";
            this.NombreTesis.Name = "NombreTesis";
            this.NombreTesis.ReadOnly = true;
            // 
            // PPosGrado
            // 
            this.PPosGrado.HeaderText = "P.PostGrado";
            this.PPosGrado.Name = "PPosGrado";
            this.PPosGrado.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haga doble clic para seleccionar la solicitud a pagar";
            // 
            // SolicitudPendientePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtListado);
            this.Controls.Add(this.label1);
            this.Name = "SolicitudPendientePago";
            this.Text = "Solicitudes Pendientes de Pago";
            this.Load += new System.EventHandler(this.SolicitudPendientePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTesis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPosGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
    }
}