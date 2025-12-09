using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PrjWfaTaskSoft
{
    public partial class frmAlterarMeta : Form
    {
        clsBancoDados banco = new clsBancoDados();
        int aux1;
        string codigoMeta;
        frmConsultarMetas telaConsultarMeta = new frmConsultarMetas(0);

        public frmAlterarMeta(int aux, string CodMeta, string prazoMeta, string descMeta)
        {
            InitializeComponent();

            aux1 = aux;
            codigoMeta = CodMeta;

            rtbDescricao.Text = descMeta;
            dtpPrazo.Text = prazoMeta;
            cboNomeFuncAlterar.DataSource = banco.retornaTBMetasFunc(aux);
            cboNomeFuncAlterar.DisplayMember = "nomePess";
            cboNomeFuncAlterar.ValueMember = "codUsu";
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            int nomefuncionario = Convert.ToInt32(cboNomeFuncAlterar.SelectedValue);
            try
            {
                if (cboNomeFuncAlterar.Text == "" || rtbDescricao.Text == "" || dtpPrazo.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    MessageBox.Show(clsBancoDados.spAlterarMetas(codigoMeta, aux1.ToString(), nomefuncionario.ToString(), rtbDescricao.Text.Trim(), dtpPrazo.Text.Trim()), "Alteração de Metas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar_Click(sender, e);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro" + Erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpPrazo.Text = "";
            rtbDescricao.Clear();
        }
    }
}
