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
    public partial class frmConsultarFun : Form
    {
        clsBancoDados Banco = new clsBancoDados();

        string setor = "";

        public frmConsultarFun(string desenSetor)
        {
            InitializeComponent();
            setor = desenSetor;
        }

        private void frmConsultarFun_Load(object sender, EventArgs e)
        {
            this.GridFun();
        }

        public void GridFun()
        {
            dgvFuncionarios.DataSource = Banco.ConsultarFuncionarios("select * from TaskSoftBD.pessUsu where tipoUsu = 3 and codSet = " + setor.Trim() + ";");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                try
                {
                    dgvFuncionarios.DataSource = Banco.ConsultarFuncionarios("select * from TaskSoftBD.pessUsu where nomePess like '%" + txtConsultar.Text.Trim() + "%';");
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
                    dgvFuncionarios.DataSource = Banco.ConsultarFuncionarios("select * from TaskSoftBD.pessUsu where cpfPess like '%" + txtConsultar.Text.Trim() + "%';");
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
                    dgvFuncionarios.DataSource = Banco.ConsultarFuncionarios("select * from TaskSoftBD.pessUsu where telPess like '%" + txtConsultar.Text.Trim() + "%';");
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

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbTelefone.Checked == true || rdbCpf.Checked == true)
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
