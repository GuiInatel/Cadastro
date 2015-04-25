namespace WindowsFormsApplication1
{
    partial class frmRelatorio
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cp2cadastroDataSet = new WindowsFormsApplication1.cp2cadastroDataSet();
            this.empresariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresariosTableAdapter = new WindowsFormsApplication1.cp2cadastroDataSetTableAdapters.empresariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cp2cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.empresariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(593, 405);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cp2cadastroDataSet
            // 
            this.cp2cadastroDataSet.DataSetName = "cp2cadastroDataSet";
            this.cp2cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresariosBindingSource
            // 
            this.empresariosBindingSource.DataMember = "empresarios";
            this.empresariosBindingSource.DataSource = this.cp2cadastroDataSet;
            // 
            // empresariosTableAdapter
            // 
            this.empresariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cp2cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource empresariosBindingSource;
        private cp2cadastroDataSet cp2cadastroDataSet;
        private cp2cadastroDataSetTableAdapters.empresariosTableAdapter empresariosTableAdapter;
    }
}