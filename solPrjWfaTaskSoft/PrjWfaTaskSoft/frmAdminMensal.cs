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
    public partial class frmAdminMensal : Form
    {
        clsBancoDados Banco = new clsBancoDados();

        public frmAdminMensal()
        {
            InitializeComponent();
        }

        public void GridGastoA()
        {
            dgvGastosA.DataSource = Banco.ConsultarGastosA("select * from TaskSoftBD.desenvolvimento;");
        }

        private void frmAdminMensal_Load(object sender, EventArgs e)
        {
            this.GridGastoA();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (rdbSetor.Checked == true)
            {
                try
                {

                    dgvGastosA.DataSource = Banco.ConsultarGastosA("select * from TaskSoftBD.desenvolvimento where codSet like '%" + txtFiltro.Text.Trim() + "%';");
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
            else if (rdbData.Checked == true)
            {
                try
                {
                    dgvGastosA.DataSource = Banco.ConsultarGastosA("select * from TaskSoftBD.desenvolvimento where dataDes like '%" + txtFiltro.Text.Trim() + "%';");
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
            else if (rdbValor.Checked == true)
            {
                try
                {
                    dgvGastosA.DataSource = Banco.ConsultarGastosA("select * from TaskSoftBD.desenvolvimento where gastoDes like '%" + txtFiltro.Text.Trim() + "%';");
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

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbValor.Checked == true || rdbSetor.Checked == true)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
                {
                    e.Handled = true;
                }
            }
        }
    }
}