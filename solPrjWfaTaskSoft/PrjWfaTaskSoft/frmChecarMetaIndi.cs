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
    public partial class frmChecarMetasIndi : Form
    {
        string codigoMeta="";
        clsBancoDados banco = new clsBancoDados();
        frmMetasIndividuais MetasIndi = new frmMetasIndividuais(null);

        public frmChecarMetasIndi(string codMeta, string descMeta, string prazoMeta, string entregaMeta, string justificativaMeta)
        {
            InitializeComponent();
            codigoMeta = codMeta;
            rtbDescricao.Text = descMeta;
            rtbDescricao.Enabled = false;
            dtpPrazo.Text = prazoMeta;
            dtpPrazo.Enabled = false;
            dtpEntrega.Enabled = false;
            rtbJustificativa.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpEntrega.Text = "";
            rtbJustificativa.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsBancoDados.spCheckarMetas(codigoMeta, dtpPrazo.Text.Trim(), rtbDescricao.Text.Trim(), dtpEntrega.Text.Trim(), rtbJustificativa.Text.Trim()), "Conclusão das Metas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.MetasIndi.GridUsu1();
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {

            dtpEntrega.Enabled = false;
            rtbJustificativa.Enabled = true;
            rtbJustificativa.Clear();

        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            rtbJustificativa.Text = "Concluído.";
            rtbJustificativa.Enabled = false;
            dtpEntrega.Enabled = true;

        }
    }
}
