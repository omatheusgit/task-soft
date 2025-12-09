namespace PrjWfaTaskSoft
{
    partial class frmRelatorioMetas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.metasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMetaJoin = new PrjWfaTaskSoft.DataSetMetaJoin();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metasTableAdapter = new PrjWfaTaskSoft.DataSetMetaJoinTableAdapters.metasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMetaJoin)).BeginInit();
            this.SuspendLayout();
            // 
            // metasBindingSource
            // 
            this.metasBindingSource.DataMember = "metas";
            this.metasBindingSource.DataSource = this.DataSetMetaJoin;
            // 
            // DataSetMetaJoin
            // 
            this.DataSetMetaJoin.DataSetName = "DataSetMetaJoin";
            this.DataSetMetaJoin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "ble";
            reportDataSource3.Value = this.metasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjWfaTaskSoft.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(588, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // metasTableAdapter
            // 
            this.metasTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 447);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatorioMetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rerlatório de metas setorias";
            this.Load += new System.EventHandler(this.frmRelatorioMetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMetaJoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource metasBindingSource;
        private DataSetMetaJoin DataSetMetaJoin;
        private DataSetMetaJoinTableAdapters.metasTableAdapter metasTableAdapter;
    }
}