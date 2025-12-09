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
    public partial class frmCriarMeta : Form
    {
        clsBancoDados banco = new clsBancoDados();
        int aux1 = 0;

        public frmCriarMeta(int aux)
        {
            InitializeComponent();
            aux1 = aux;
            //Funcionário
            cboNomeFunc.DataSource = banco.retornaTBMetasFunc(aux);
            cboNomeFunc.DisplayMember = "nomePess";
            cboNomeFunc.ValueMember = "codUsu";

        }

        private void btnInserirMetas_Click_1(object sender, EventArgs e)
        {
            if (cboNomeFunc.SelectedIndex == -1)
            {
                MessageBox.Show("Gerente, Verifique se você selecionou ou se há funcionários no seu setor");
                cboNomeFunc.Focus();
            }
            else if (dtpPrazoMeta.Text.Equals(""))
            {
                MessageBox.Show("Gerente, Preencha o campo Prazo Meta!");
                dtpPrazoMeta.Focus();
            }
            else if (rtbDescricaoMeta.Text.Equals(""))
            {
                MessageBox.Show("Gerente, Preencha o campo Descrição!");
                rtbDescricaoMeta.Focus();
            }
            else
            {
                try
                {
                    int nomefuncionario = Convert.ToInt32(cboNomeFunc.SelectedValue);

                    MessageBox.Show(clsBancoDados.spInserirMetas(aux1, nomefuncionario, dtpPrazoMeta.Text.Trim(), rtbDescricaoMeta.Text.Trim()), "Cadastro de Metas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimparMetas_Click(sender, e);
                }

                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao conectar com o servidor de dados!, INHAURAURcontate o administrador!");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparMetas_Click(object sender, EventArgs e)
        {
            dtpPrazoMeta.Text = "";
            rtbDescricaoMeta.Clear();
        }
    }
}
