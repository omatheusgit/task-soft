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
    public partial class frmCriarUsu : Form
    {
        int tipoUser = 0;
        string codSetor;
        MySqlConnection objCnx = new MySqlConnection("Server=localhost;Database=TaskSoftBD;user=alunos;pwd=etec");
        MySqlCommand objCmd = new MySqlCommand();
        MySqlDataReader objDados;
        public frmCriarUsu()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtRua.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            cboNomeSetor.SelectedIndex = -1;
            txtUsuario.Clear();
            txtSenha.Clear();
            rdoFuncionario.Checked = false;
            rdoGerente.Checked = false;
            txtNome.Focus();
            txtNumCasa.Clear();
            txtComplemento.Clear();
            txtTelefone.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cboNomeSetor.SelectedIndex == -1 || txtNome.Text.Equals("") || txtRua.Text.Equals("") || txtNumCasa.Text.Equals("") || txtEmail.Text.Equals("") || txtTelefone.Text.Equals("") || txtCpf.Text.Equals("") || txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos para realizar o cadastro");
            }
            else
            {
                if (rdoAdm.Checked == true)
                {
                    codSetor = "0";
                }
                else if (cboNomeSetor.Text.Equals("1 - Contabilidade"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_01";
                    codSetor = "1";
                }
                else if (cboNomeSetor.Text.Equals("2 - Recursos Humanos"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_02";
                    codSetor = "2";
                }
                else if (cboNomeSetor.Text.Equals("3 - Fiscal"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_03";
                    codSetor = "3";
                }
                else if (cboNomeSetor.Text.Equals("4 - Faturamento"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_04";
                    codSetor = "4";
                }
                else if (cboNomeSetor.Text.Equals("5 - Produção e Estoque"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_05";
                    codSetor = "5";
                }
                else if (cboNomeSetor.Text.Equals("6 - Financeiro"))
                {
                    txtUsuario.Text = txtUsuario.Text + "_06";
                    codSetor = "6";
                }
                string endTotal = "R: " + txtRua.Text.Trim() + " Nº " + txtNumCasa.Text.Trim() + " Comp: " + txtComplemento.Text.Trim();
                try
                {
                    string m = (clsBancoDados.spCadastrarUsuario(codSetor, txtNome.Text.Trim(), endTotal, txtEmail.Text.Trim(), txtTelefone.Text, txtCpf.Text.Trim(), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), tipoUser));
                    if (m.Equals("Alguns dos campos Nome, Cpf e Usuário já existentes!"))
                    {
                        MessageBox.Show("Alguns dos campos Nome, Cpf e Usuário já existentes!");
                    }
                    else if(m.Contains("_0"))
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso! "+m);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao conectar com o servidor de dados!, contate o administrador!");
                }
            }
        }  
        private void rdoFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            tipoUser = 3;
            cboNomeSetor.Enabled = true;
        }

        private void rdoGerente_CheckedChanged(object sender, EventArgs e)
        {
            tipoUser = 2;
            cboNomeSetor.Enabled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
                {
                    e.Handled = true;
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtDdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void rdoAdm_CheckedChanged(object sender, EventArgs e)
        {
            tipoUser = 1;
            cboNomeSetor.Enabled = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCriarUsu_Load(object sender, EventArgs e)
        {
            rdoFuncionario.Checked = true;
        }

        private void txtNumCasa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
