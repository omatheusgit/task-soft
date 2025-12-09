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
    public partial class frmConsultarUsu : Form
    {
        clsBancoDados Banco = new clsBancoDados();

        public frmConsultarUsu()
        {
            InitializeComponent();
        }
        public void GridUsu()
        {
           dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu;");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirUsu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse usuário!?", "Gerenciamento de Usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show(clsBancoDados.fExcluirUsuario(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada!", "Gerenciamento de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.GridUsu();
        }

        private void btnAlterarUsu_Click(object sender, EventArgs e)
        {
            frmAlterarUsu alterUsu = new frmAlterarUsu(dgvUsuarios.CurrentRow.Cells[0].Value.ToString(), dgvUsuarios.CurrentRow.Cells[1].Value.ToString(), dgvUsuarios.CurrentRow.Cells[2].Value.ToString(), dgvUsuarios.CurrentRow.Cells[3].Value.ToString(), dgvUsuarios.CurrentRow.Cells[4].Value.ToString(), dgvUsuarios.CurrentRow.Cells[5].Value.ToString(), dgvUsuarios.CurrentRow.Cells[6].Value.ToString(), dgvUsuarios.CurrentRow.Cells[7].Value.ToString(), dgvUsuarios.CurrentRow.Cells[8].Value.ToString());
            alterUsu.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.GridUsu();
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                try
                {

                    dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu where nomePess like '%" + txtConsultar.Text.Trim() + "%';");
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
            else if (rdbCpf.Checked == true)
            {
                try
                {
                    dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu where cpfPess like '%" + txtConsultar.Text.Trim() + "%';");
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
            else if (rdbTelefone.Checked == true)
            {
                try
                {
                    dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu where telPess like '%" + txtConsultar.Text.Trim() + "%';");
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
            else if (rdbSet.Checked == true)
            {
                try
                {
                    dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu where codSet like '%" + txtConsultar.Text.Trim() + "%';");
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
            else if (rdbTipo.Checked == true)
            {
                try
                {
                    dgvUsuarios.DataSource = Banco.ConsultarUsuarios("select * from TaskSoftBD.pessUsu where tipoUsu like '%" + txtConsultar.Text.Trim() + "%';");
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

        private void frmConsultarUsu_Load(object sender, EventArgs e)
        {
            this.GridUsu();
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdbTelefone.Checked == true || rdbCpf.Checked == true || rdbSet.Checked == true)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
                {
                    e.Handled = true;
                }
            }
            else if (rdbNome.Checked == true)
            {
                string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";

                if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }


    }
}
