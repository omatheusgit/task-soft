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
    public partial class frmGerenciaMensal : Form
    {
        public clsBancoDados Banco = new clsBancoDados();

        string desenGer = "";

        public frmGerenciaMensal(string desen1)
        {
            InitializeComponent();
            desenGer = desen1;
        }

        private void frmGerenciaMensal_Load(object sender, EventArgs e)
        {
            this.GridGerenciaMen();
        }

        private void GridGerenciaMen()
        {
            dgvGastos.DataSource = Banco.ConsultarGerGastos("Select codDes , dataDes , gastoDes from TaskSoftBD.desenvolvimento where codSet = " + desenGer + ";");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Cadastro de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    MessageBox.Show(clsBancoDados.spInserirGastos(desenGer.Trim(), txtValor1.Text.Trim(), txtValor.Text.Trim()), "Cadastro de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor.Clear();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message);
                }
            }
            GridGerenciaMen();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = '.';

                if (txtValor.Text.Contains("."))
                    e.Handled = true; // Caso exista, aborte 

            }
            else if (e.KeyChar == '-')
            {
                e.KeyChar = '-';

                if (txtValor.Text.Contains("-"))
                    e.Handled = true; // Caso exista, aborte 
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarGasto AlterarGasto = new frmAlterarGasto(dgvGastos.CurrentRow.Cells[0].Value.ToString(), dgvGastos.CurrentRow.Cells[1].Value.ToString(), dgvGastos.CurrentRow.Cells[2].Value.ToString());
            AlterarGasto.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            GridGerenciaMen();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o gasto mensal!?", "Gerenciamento de Gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show(clsBancoDados.fExcluirGastos(dgvGastos.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Exclusão cancelada!", "Gerenciamento de Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.GridGerenciaMen();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioDesenvolvimento telaRel = new frmRelatorioDesenvolvimento();
            telaRel.ShowDialog();
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)4)
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor1.Text = "";
        }
    }
}
