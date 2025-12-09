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
    public partial class frmAlterarSenha : Form
    {
        clsBancoDados Banco = new clsBancoDados();

        public frmAlterarSenha(string idUsu)
        {
            InitializeComponent();
            txtUsuario.Text = idUsu;
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenhaA.Text = "";
            txtSenhaN.Text = "";
            txtSenhaC.Text = "";
            txtSenhaA.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSenhaN.Text == txtSenhaC.Text)
                {
                    string strSql = "Update pessUsu set ";
                    strSql += "senhaUsu = '" + txtSenhaN.Text + "' ";
                    strSql += "Where idUsu = '" + txtUsuario.Text + "'";

                    if (Banco.ExecutarSQL(strSql) > 0)
                    {
                        MessageBox.Show("Senha alterada com sucesso!", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Usuário não existente!", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Erro na confirmação de senha", "Alteração de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
            catch (Exception objErro)
            {
                MessageBox.Show("Erro no Banco de Dados ==>  " + objErro.Message, "Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                
    }
}
