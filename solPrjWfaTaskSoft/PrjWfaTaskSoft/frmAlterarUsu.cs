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
    public partial class frmAlterarUsu : Form
    {
        clsBancoDados Banco = new clsBancoDados();
        frmConsultarUsu telaConsultar = new frmConsultarUsu();
        int tipoUser, codUsuu, setorr;
        public frmAlterarUsu(string codUsu, string setor, string id, string nome, string email, string telefone, string endereco, string cpf, string tipo)
        {
            InitializeComponent();

            codUsuu = Int32.Parse(codUsu);
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtTelefone.Text = telefone;
            txtEmail.Text = email;
            txtCpf.Text = cpf;
             setorr= Int32.Parse(setor);
            txtUsuario.Text = id;
            tipoUser = Convert.ToInt16(tipo);

            if(tipoUser == 2)
            {
                rdoGerente.Checked = true;
            }
            else if(tipoUser == 3)
            {
                rdoFuncionario.Checked = true;
            }
            else if (tipoUser == 1)
            {
                rdoAdm.Checked = true;
            }

            if (setorr == 1)
            {
                cboNomeSetor.SelectedIndex = 0;
            }
            else if (setorr == 2)
            {
                cboNomeSetor.SelectedIndex = 1;
            }
            else if (setorr == 3)
            {
                cboNomeSetor.SelectedIndex = 2;
            }
            else if (setorr == 4)
            {
                cboNomeSetor.SelectedIndex = 3;
            }
            else if (setorr == 5)
            {
                cboNomeSetor.SelectedIndex = 4;
            }
            else if (setorr == 6)
            {
                cboNomeSetor.SelectedIndex = 5;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(rdoFuncionario.Checked == true)
            {
                tipoUser = 3;
            }
            else if (rdoGerente.Checked == true)
            {
                tipoUser = 2;
            }
            else if (rdoAdm.Checked == true)
            {
                tipoUser = 1;
            }

            if (cboNomeSetor.SelectedIndex == -1 || txtNome.Text.Equals("") || txtEndereco.Text.Trim().Equals("") || txtEmail.Text.Equals("") || txtTelefone.Text.Equals("") || txtCpf.Text.Equals("") || txtUsuario.Text.Equals("") || txtSenha.Text.Equals("") || tipoUser == 0)
            {
                MessageBox.Show("Preencha todos os campos para efetuar a Alteração!");
                Banco.Desconectar();
            }
            else
            {
                try
                {
                    MessageBox.Show(clsBancoDados.spAlterarUsuario(codUsuu.ToString(), setorr.ToString(), txtNome.Text.Trim(), txtEndereco.Text.Trim(), txtEmail.Text.Trim(), txtTelefone.Text.Trim(), txtCpf.Text.Trim(), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), tipoUser), "Alteração de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Banco.Desconectar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao conectar com o servidor de dados!, contate o administrador!");
                }
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
