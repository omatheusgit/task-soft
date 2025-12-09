using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWfaTaskSoft
{
    public partial class frmRelatorioMetas : Form
    {
        int setor = 0;
        string data;
        public frmRelatorioMetas(int codSet)
        {
            InitializeComponent();
            setor = codSet;
        }

        private void frmRelatorioMetas_Load(object sender, EventArgs e)
        {
            string  data1 = DateTime.Now.ToString("dd MM yyyy HH:mm");
            data = data1;

            // TODO: This line of code loads data into the 'DataSetMetaJoin.metas' table. You can move, or remove it, as needed.
            this.metasTableAdapter.Fill(this.DataSetMetaJoin.metas,setor);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", data));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

            
        }
    }
}
