namespace Estandar
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SOLICITUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_TESISDataSet = new Estandar.BD_TESISDataSet();
            this.SOLICITUDTableAdapter = new Estandar.BD_TESISDataSetTableAdapters.SOLICITUDTableAdapter();
            this.sOLICITUDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MIEMBROS_HORARIO = new Estandar.MIEMBROS_HORARIO();
            this.HORARIO_TESIS_POR_SOLICITUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HORARIO_TESIS_POR_SOLICITUDTableAdapter = new Estandar.MIEMBROS_HORARIOTableAdapters.HORARIO_TESIS_POR_SOLICITUDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SOLICITUDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_TESISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIEMBROS_HORARIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORARIO_TESIS_POR_SOLICITUDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SOLICITUDBindingSource
            // 
            this.SOLICITUDBindingSource.DataMember = "SOLICITUD";
            this.SOLICITUDBindingSource.DataSource = this.BD_TESISDataSet;
            // 
            // BD_TESISDataSet
            // 
            this.BD_TESISDataSet.DataSetName = "BD_TESISDataSet";
            this.BD_TESISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SOLICITUDTableAdapter
            // 
            this.SOLICITUDTableAdapter.ClearBeforeFill = true;
            // 
            // sOLICITUDBindingSource1
            // 
            this.sOLICITUDBindingSource1.DataMember = "SOLICITUD";
            this.sOLICITUDBindingSource1.DataSource = this.BD_TESISDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SOLICITUDBindingSource;
            reportDataSource2.Name = "DataSetHorarios";
            reportDataSource2.Value = this.HORARIO_TESIS_POR_SOLICITUDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Estandar.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(873, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // MIEMBROS_HORARIO
            // 
            this.MIEMBROS_HORARIO.DataSetName = "MIEMBROS_HORARIO";
            this.MIEMBROS_HORARIO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HORARIO_TESIS_POR_SOLICITUDBindingSource
            // 
            this.HORARIO_TESIS_POR_SOLICITUDBindingSource.DataMember = "HORARIO_TESIS_POR_SOLICITUD";
            this.HORARIO_TESIS_POR_SOLICITUDBindingSource.DataSource = this.MIEMBROS_HORARIO;
            // 
            // HORARIO_TESIS_POR_SOLICITUDTableAdapter
            // 
            this.HORARIO_TESIS_POR_SOLICITUDTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SOLICITUDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_TESISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIEMBROS_HORARIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORARIO_TESIS_POR_SOLICITUDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SOLICITUDBindingSource;
        private BD_TESISDataSet BD_TESISDataSet;
        private BD_TESISDataSetTableAdapters.SOLICITUDTableAdapter SOLICITUDTableAdapter;
        private System.Windows.Forms.BindingSource sOLICITUDBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HORARIO_TESIS_POR_SOLICITUDBindingSource;
        private MIEMBROS_HORARIO MIEMBROS_HORARIO;
        private MIEMBROS_HORARIOTableAdapters.HORARIO_TESIS_POR_SOLICITUDTableAdapter HORARIO_TESIS_POR_SOLICITUDTableAdapter;
    }
}