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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
                string m;
            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos para efetuar o login");
            }
            else
            {
                try
                {
                    m = (clsBancoDados.fVerificaLogin(txtUsuario.Text.Trim(), txtSenha.Text.Trim()));
                    MessageBox.Show(m);
                    if (m.Equals("Administrador logado com sucesso!"))
                    {
                        this.Hide();
                        frmMenu menu = new frmMenu("Administrador", txtUsuario.Text);
                        menu.ShowDialog();
                        this.Close();
                    }
                    else if (m.Equals("Gerente logado com sucesso!"))
                    {
                        this.Hide();
                        frmMenu menu = new frmMenu("Gerente", txtUsuario.Text);
                        menu.ShowDialog();
                    }
                    else if (m.Equals("Funcionário logado com sucesso"))
                    {
                        this.Hide();
                        frmMenu menu = new frmMenu("Funcionario", txtUsuario.Text);
                        menu.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o servidor de dados!, INHAURAURcontate o administrador!", "Autenticação de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}