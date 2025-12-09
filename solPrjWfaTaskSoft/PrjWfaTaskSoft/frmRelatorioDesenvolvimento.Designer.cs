namespace PrjWfaTaskSoft
{
    partial class frmRelatorioDesenvolvimento
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
            this.DataSetDesenvolvimentoSetor = new PrjWfaTaskSoft.DataSetDesenvolvimentoSetor();
            this.desenvolvimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desenvolvimentoTableAdapter = new PrjWfaTaskSoft.DataSetDesenvolvimentoSetorTableAdapters.desenvolvimentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDesenvolvimentoSetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvimentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDesenvolvimento";
            reportDataSource1.Value = this.desenvolvimentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjWfaTaskSoft.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(588, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetDesenvolvimentoSetor
            // 
            this.DataSetDesenvolvimentoSetor.DataSetName = "DataSetDesenvolvimentoSetor";
            this.DataSetDesenvolvimentoSetor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desenvolvimentoBindingSource
            // 
            this.desenvolvimentoBindingSource.DataMember = "desenvolvimento";
            this.desenvolvimentoBindingSource.DataSource = this.DataSetDesenvolvimentoSetor;
            // 
            // desenvolvimentoTableAdapter
            // 
            this.desenvolvimentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioDesenvolvimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 447);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatorioDesenvolvimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de gastos Setoriais";
            this.Load += new System.EventHandler(this.frmRelatorioDesenvolvimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDesenvolvimentoSetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvimentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource desenvolvimentoBindingSource;
        private DataSetDesenvolvimentoSetor DataSetDesenvolvimentoSetor;
        private DataSetDesenvolvimentoSetorTableAdapters.desenvolvimentoTableAdapter desenvolvimentoTableAdapter;
    }
}