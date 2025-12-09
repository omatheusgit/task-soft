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
    public partial class frmMetasIndividuais : Form
    {
        string AcertoTecnico = "";
        public clsBancoDados banco = new clsBancoDados();
        public frmMetasIndividuais(string idUsuu)
        {
            InitializeComponent();
            AcertoTecnico = idUsuu;
        }

        public void GridUsu1()
        {

            dgvMetasIndividuais.DataSource = banco.MetaIndividual("select * from metas join pessUsu on metas.codUsu = pessUsu.codUsu where pessUsu.idUsu = '" + AcertoTecnico + "';");
        }

        private void txtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMetasIndividuais_Load(object sender, EventArgs e)
        {
            this.GridUsu1();
        }

        private void txtConsultarMetaIndi_TextChanged(object sender, EventArgs e)
        {

            if (rdbDescricaoMetaIndi.Checked == true)
            {
                try
                {
                    dgvMetasIndividuais.DataSource = banco.MetaIndividual("select * from TaskSoftBD.metas join pessUsu on metas.codUsu = pessUsu.codUsu where pessUsu.idUsu = '" + AcertoTecnico + "' and descMeta like '%" + txtConsultarMetaIndi.Text.Trim() + "%';");
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro no filtro de pesquisa, contate o administrador!", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    banco.Desconectar();
                }
            }

            if (rdbDataMetaIndi.Checked == true)
            {
                try
                {

                    dgvMetasIndividuais.DataSource = banco.MetaIndividual("select * from TaskSoftBD.metas join pessUsu on metas.codUsu = pessUsu.codUsu where pessUsu.idUsu = '" + AcertoTecnico + "' and prazoMeta like '%" + txtConsultarMetaIndi.Text.Trim() + "%';");

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro no filtro de pesquisa, contate o administrador!", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    banco.Desconectar();
                }
            }
        }

        private void txtChecarMeta_Click(object sender, EventArgs e)
        {
            try
            {
                frmChecarMetasIndi checarMeta = new frmChecarMetasIndi(dgvMetasIndividuais.CurrentRow.Cells[0].Value.ToString(), dgvMetasIndividuais.CurrentRow.Cells[1].Value.ToString(), dgvMetasIndividuais.CurrentRow.Cells[2].Value.ToString(), dgvMetasIndividuais.CurrentRow.Cells[3].Value.ToString(), dgvMetasIndividuais.CurrentRow.Cells[4].Value.ToString());
                checarMeta.ShowDialog();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Você não possui metas individuais!", "Metas individuais", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            this.GridUsu1();
        }
    }
}
