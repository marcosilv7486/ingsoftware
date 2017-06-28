namespace Estandar
{
    partial class ListadoSolicitudes
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
            this.tabEstados = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.tab5 = new System.Windows.Forms.TabPage();
            this.tab6 = new System.Windows.Forms.TabPage();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
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
            this.tabEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Solicitudes";
            // 
            // tabEstados
            // 
            this.tabEstados.Controls.Add(this.tab1);
            this.tabEstados.Controls.Add(this.tab3);
            this.tabEstados.Controls.Add(this.tab5);
            this.tabEstados.Controls.Add(this.tab6);
            this.tabEstados.Controls.Add(this.tab4);
            this.tabEstados.Controls.Add(this.tab2);
            this.tabEstados.Location = new System.Drawing.Point(12, 49);
            this.tabEstados.Name = "tabEstados";
            this.tabEstados.SelectedIndex = 0;
            this.tabEstados.Size = new System.Drawing.Size(944, 30);
            this.tabEstados.TabIndex = 3;
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(936, 4);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Generados";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(936, 4);
            this.tab3.TabIndex = 1;
            this.tab3.Text = "Canceladas";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // tab5
            // 
            this.tab5.Location = new System.Drawing.Point(4, 22);
            this.tab5.Name = "tab5";
            this.tab5.Padding = new System.Windows.Forms.Padding(3);
            this.tab5.Size = new System.Drawing.Size(936, 4);
            this.tab5.TabIndex = 2;
            this.tab5.Text = "Aprobadas";
            this.tab5.UseVisualStyleBackColor = true;
            // 
            // tab6
            // 
            this.tab6.Location = new System.Drawing.Point(4, 22);
            this.tab6.Name = "tab6";
            this.tab6.Padding = new System.Windows.Forms.Padding(3);
            this.tab6.Size = new System.Drawing.Size(936, 4);
            this.tab6.TabIndex = 3;
            this.tab6.Text = "Finalizadas";
            this.tab6.UseVisualStyleBackColor = true;
            // 
            // tab4
            // 
            this.tab4.Location = new System.Drawing.Point(4, 22);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(936, 4);
            this.tab4.TabIndex = 4;
            this.tab4.Text = "Desaprobadas";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(936, 4);
            this.tab2.TabIndex = 5;
            this.tab2.Text = "Anuladas";
            this.tab2.UseVisualStyleBackColor = true;
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
            this.dtListado.Location = new System.Drawing.Point(12, 85);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(945, 336);
            this.dtListado.TabIndex = 4;
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
            // ListadoSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 434);
            this.Controls.Add(this.dtListado);
            this.Controls.Add(this.tabEstados);
            this.Controls.Add(this.label1);
            this.Name = "ListadoSolicitudes";
            this.Text = "Listado de Solicitudes";
            this.Load += new System.EventHandler(this.ListadoSolicitudes_Load);
            this.tabEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabEstados;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TabPage tab5;
        private System.Windows.Forms.TabPage tab6;
        private System.Windows.Forms.TabPage tab4;
        private System.Windows.Forms.TabPage tab2;
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
    }
}