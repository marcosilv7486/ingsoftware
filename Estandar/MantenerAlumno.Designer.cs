namespace Estandar
{
    partial class MantenerAlumno
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
            this.dtDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mantenimiento de Alumnos";
            // 
            // dtDatos
            // 
            this.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDatos.Location = new System.Drawing.Point(12, 68);
            this.dtDatos.Name = "dtDatos";
            this.dtDatos.Size = new System.Drawing.Size(858, 267);
            this.dtDatos.TabIndex = 4;
            // 
            // MantenerAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 347);
            this.Controls.Add(this.dtDatos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MantenerAlumno";
            this.Text = "MantenerAlumno";
            this.Load += new System.EventHandler(this.MantenerAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtDatos;
    }
}