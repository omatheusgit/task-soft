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
    public partial class frmRelatorioDesenvolvimento : Form
    {
        string data;

        public frmRelatorioDesenvolvimento()
        {
            InitializeComponent();
        }

        private void frmRelatorioDesenvolvimento_Load(object sender, EventArgs e)
        {
            string data1 = DateTime.Now.ToString("dd MM yyyy HH:mm");
            data = data1;

            // TODO: This line of code loads data into the 'DataSetDesenvolvimentoSetor.desenvolvimento' table. You can move, or remove it, as needed.
            this.desenvolvimentoTableAdapter.Fill(this.DataSetDesenvolvimentoSetor.desenvolvimento);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", data));
            this.reportViewer1.RefreshReport();
        }
    }
}
