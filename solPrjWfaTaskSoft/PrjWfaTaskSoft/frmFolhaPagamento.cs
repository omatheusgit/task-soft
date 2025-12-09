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
    public partial class frmFolhaPagamento : Form
    {
        clsBancoDados Banco = new clsBancoDados();

        private MySqlConnection objCnx = new MySqlConnection();
        string salbruto; 
        public frmFolhaPagamento()
        {
            InitializeComponent();
            txtSalBruto.Text = dgvConsultaSalario.CurrentRow.Cells[3].Value.ToString();
        }
        
        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {
            
            objCnx.ConnectionString = "Server=localhost;Database=TaskSoftBD;user=alunos;pwd=etec";
            GridSal();

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        public void GridSal()
        {
            dgvConsultaSalario.DataSource = Banco.ConsultarSalarios("select codUsu , salliquidoPess , salbrutoPess , nomePess , cpfPess from TaskSoftBD.pessUsu where tipoUsu = 3 and codSet = 1");            
        }//fim

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
