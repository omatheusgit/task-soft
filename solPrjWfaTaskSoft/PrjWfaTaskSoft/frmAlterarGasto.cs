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
    public partial class frmAlterarGasto : Form
    {
        public frmAlterarGasto(string codGasto, string dataGasto, string valorGasto)
        {
            InitializeComponent();

            txtCodigo.Text = codGasto;
            txtData.Text = dataGasto;
            txtValor.Text = valorGasto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsBancoDados.spAlterarGastos(txtCodigo.Text.Trim(), txtData.Text.Trim(), txtValor.Text.Trim()), "Alteração de Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
