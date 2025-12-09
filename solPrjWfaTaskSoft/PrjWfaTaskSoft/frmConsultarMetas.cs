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
    public partial class frmConsultarMetas : Form
    {
        public clsBancoDados Banco = new clsBancoDados();
        int aux1 = 0;
        public frmConsultarMetas(int aux)
        {
            InitializeComponent();
            aux1 = aux;
        }

        public void GridMeta()
        {
            dgvMetas.DataSource = Banco.Consultar("select * from metas join pessusu on metas.codUsu = pessUsu.codUsu join setorEmpresa on metas.codSet = setorEmpresa.codSet where setorEmpresa.codSet = '" + aux1 + "'");
        }

        private void btnAlterarMetas_Click_1(object sender, EventArgs e)
        {
            frmAlterarMeta alterarMeta = new frmAlterarMeta(aux1, dgvMetas.CurrentRow.Cells[0].Value.ToString(), dgvMetas.CurrentRow.Cells[2].Value.ToString(), dgvMetas.CurrentRow.Cells[3].Value.ToString());
            alterarMeta.ShowDialog();
        }

        private void frmConsultarMetas_Load_1(object sender, EventArgs e)
        {
            this.GridMeta();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirMetas_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir essa Meta!?", "Gerenciamento de Metas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show(clsBancoDados.fExcluirMeta(dgvMetas.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada!", "Gerenciamento de Metas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.GridMeta();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.GridMeta();
            txtConsultarMeta.Clear();
            txtConsultarMeta.Focus();
        }

        private void txtConsultarMeta_TextChanged(object sender, EventArgs e)
        {
            if (rdbNomeMeta.Checked == true)
            {
                try
                {

                    dgvMetas.DataSource = Banco.Consultar("select * from TaskSoftBD.metas join pessusu on metas.codUsu = pessUsu.codUsu join setorEmpresa on metas.codSet = setorEmpresa.codSet where setorEmpresa.codSet = '" + aux1 + "' and descMeta like '%" + txtConsultarMeta.Text.Trim() + "%';");
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro no filtro de pesquisa, contate o administrador!", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Banco.Desconectar();
                }
            }
            else if (rdbDataMeta.Checked == true)
            {
                try
                {
                    dgvMetas.DataSource = Banco.Consultar("select * from TaskSoftBD.metas  join pessusu on metas.codUsu = pessUsu.codUsu join setorEmpresa on metas.codSet = setorEmpresa.codSet where setorEmpresa.codSet = '" + aux1 + "' and prazoMeta like '%" + txtConsultarMeta.Text.Trim() + "%';");
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro no filtro de pesquisa, contate o administrador!", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Banco.Desconectar();
                }
            }
        }
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioMetas telRel = new frmRelatorioMetas(aux1);
            telRel.ShowDialog();
        }

        private void txtConsultarMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbDataMeta.Checked == true)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
                {
                    e.Handled = true;
                }
            }
        }
    }
}