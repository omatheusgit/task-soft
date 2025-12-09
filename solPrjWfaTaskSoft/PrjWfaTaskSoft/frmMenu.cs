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
    public partial class frmMenu : Form
    {
        public string permUsu = "";
        public string idUsuu = "";
        public string desen = "";
        public int aux = 0;
        DateTime tempo1;        
        
        public frmMenu(string permissaoUsu, string idUsu)
        {
            InitializeComponent();
            permUsu = permissaoUsu;
            idUsuu = idUsu;
        }

        private void mnuLogoff_Click(object sender, EventArgs e)
        {
            Close();
            Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (permUsu == "Funcionario")
            {
                mnuEmpresa.Visible = false;
                mnuGerUsu.Visible = false;
                MnuSetor.Visible = false;
                mnuGerMetas.Visible = false;
            }
            else if(permUsu == "Gerente")
            {
                mnuEmpresa.Visible = false;
                minhasMetasToolStripMenuItem.Visible = false;
                mnuGerUsu.Visible = false;
                if (idUsuu.Contains("01"))
                {                    
                    desen = "1";
                    aux = 1;
                }
                else if (idUsuu.Contains("02"))
                {
                    desen = "2";
                    aux = 2;
                }
                else if (idUsuu.Contains("03"))
                {
                    desen = "3";
                    aux = 3;
                }
                else if (idUsuu.Contains("04"))
                {
                    desen = "4";
                    aux = 4;
                }
                else if (idUsuu.Contains("05"))
                {
                    desen = "5";
                    aux = 5;
                }
                else if (idUsuu.Contains("06"))
                {
                    desen = "6";
                    aux = 6;
                }
            }
            else if (permUsu == "Administrador")
            {
                minhasMetasToolStripMenuItem.Visible = false;
                mnuGerMetas.Visible = false;
                MnuSetor.Visible = false;
            }
                this.nome();
        }

        private void MnuGerUsuSubConsultarUsu_Click(object sender, EventArgs e)
        {
            frmConsultarUsu Gerenciar = new frmConsultarUsu();
            Gerenciar.ShowDialog();
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            tspData.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
            tspHora.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime tempo = DateTime.Now;
            tempo1 = tempo;

            if (tempo.Hour > 6 && tempo.Hour < 12)
                tspMensagem.Text = "Bom dia, " + idUsuu;
            else if (tempo.Hour >= 12 && tempo.Hour < 18)
                tspMensagem.Text = "Boa tarde, " + idUsuu;
            else
                tspMensagem.Text = "Boa noite, " + idUsuu;
        }

        private void mnuConfgSubAlterSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha AlterarSenha = new frmAlterarSenha(idUsuu);
            AlterarSenha.ShowDialog();
        }

        private void MnuGerUsuSubCriarUsu_Click(object sender, EventArgs e)
        {
            frmCriarUsu CriarUsu = new frmCriarUsu();
            CriarUsu.ShowDialog();
        }
        

        private void mnuGerMetasSubCriarMetas_Click(object sender, EventArgs e)
        {
            frmCriarMeta CriarMeta = new frmCriarMeta(aux);
            CriarMeta.ShowDialog();
        }

        private void mnuGerMetasSubConsulMetas_Click(object sender, EventArgs e)
        {
            frmConsultarMetas ConMetas = new frmConsultarMetas(aux);
            ConMetas.ShowDialog();
        }
        private void nome()
        {
            string m = "";
            m = (clsBancoDados.fRetornaNome(idUsuu));
            if (tempo1.Hour >= 6 && tempo1.Hour < 12)
            {
                tspMensagem.Text = "Bom dia, " + m;
            }
            else if (tempo1.Hour >= 12 && tempo1.Hour < 18)
            {
                tspMensagem.Text = "Boa tarde, " + m;
            }
            else if (tempo1.Hour >= 18 && tempo1.Hour < 6)
            {
                tspMensagem.Text = "Boa noite, " + m;
            }
        }

        private void MnuSetorSubDesen_Click(object sender, EventArgs e)
        {
            frmGerenciaMensal desenvolvimento = new frmGerenciaMensal(desen);
            desenvolvimento.ShowDialog();
        }

        private void minhasMetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetasIndividuais metasIndi = new frmMetasIndividuais(idUsuu);
            metasIndi.ShowDialog();
        }

        private void consultarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFun consultarFun = new frmConsultarFun(desen);
            consultarFun.ShowDialog();
        }        

        private void MnuEmpSubGastos_Click(object sender, EventArgs e)
        {
            frmAdminMensal Empresa = new frmAdminMensal();
            Empresa.ShowDialog();
        }
    }
}
