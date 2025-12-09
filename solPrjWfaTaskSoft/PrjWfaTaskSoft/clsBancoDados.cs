using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PrjWfaTaskSoft
{
    public class clsBancoDados
    {
        private static MySqlConnection objCnx = new MySqlConnection();
        private static MySqlCommand objCmd = new MySqlCommand();
        private static MySqlDataReader objDados;
        private DataTable tbMetas = new DataTable();
        private static string strConexao = "server=localhost;Database=tasksoftbd;user=alunos;pwd=etec";
        public static string strMsg { get; private set; }

        public bool Conectar()
        {
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();
                return true;
            }
            catch (Exception Erro)
            {
                strMsg = Erro.Message;
                return false;
            }
        }

        public void Desconectar()
        {
            try
            {
                objCnx.Close();
            }
            catch (Exception Erro)
            {
                strMsg = Erro.Message;
            }
        }

        //Procedures e Funções

        public static string spCadastrarUsuario(string pcodSet, string pnomePess, string pendPess, string pemailPess, string ptelPess, string pcpfPess, string pidUsu, string psenhaUsu, int ptipoUsu)
        {
            string retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();

                MySqlCommand objCmd = new MySqlCommand("spCadastrarUsuario", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pcodSet", pcodSet);
                objCmd.Parameters["pcodSet"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pnomePess", pnomePess);
                objCmd.Parameters["pnomePess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pendPess", pendPess);
                objCmd.Parameters["pendPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pemailPess", pemailPess);
                objCmd.Parameters["pemailPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("ptelPess", ptelPess);
                objCmd.Parameters["ptelPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pcpfPess", pcpfPess);
                objCmd.Parameters["pcpfPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pidUsu", pidUsu);
                objCmd.Parameters["pidUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("psenhaUsu", psenhaUsu);
                objCmd.Parameters["psenhaUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("ptipoUsu", ptipoUsu);
                objCmd.Parameters["ptipoUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.Add(("aux"), MySqlDbType.VarChar, 50);
                objCmd.Parameters[("aux")].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["aux"].Value.ToString();

                objCnx.Close();

            }
            catch (Exception Erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }


        public static string spAlterarUsuario(string pcodUsu, string pcodSet, string pnomePess, string pendPess, string pemailPess, string ptelPess, string pcpfPess, string pidUsu, string psenhaUsu, int ptipoUsu)
        {
            string retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();
                MySqlCommand objCmd = new MySqlCommand("spAlterarUsuario", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pcodUsu", pcodUsu);
                objCmd.Parameters["pcodUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pcodSet", pcodSet);
                objCmd.Parameters["pcodSet"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pnomePess", pnomePess);
                objCmd.Parameters["pnomePess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pendPess", pendPess);
                objCmd.Parameters["pendPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pemailPess", pemailPess);
                objCmd.Parameters["pemailPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("ptelPess", ptelPess);
                objCmd.Parameters["ptelPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pcpfPess", pcpfPess);
                objCmd.Parameters["pcpfPess"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pidUsu", pidUsu);
                objCmd.Parameters["pidUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("psenhaUsu", psenhaUsu);
                objCmd.Parameters["psenhaUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("ptipoUsu", ptipoUsu);
                objCmd.Parameters["ptipoUsu"].Direction = ParameterDirection.Input;

                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();
            }
            catch (Exception erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }


        public static string spInserirMetas(int pNomeSetor, int pCodfunc, string pPrazoMeta, string pDescricao)
        {
            String retorno = "";

            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();

                MySqlCommand objCmd = new MySqlCommand("spInserirMetas", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pNomeSetor", pNomeSetor);
                objCmd.Parameters["pNomeSetor"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pCodfunc", pCodfunc);
                objCmd.Parameters["pCodfunc"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pPrazoMeta", pPrazoMeta);
                objCmd.Parameters["pPrazoMeta"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pDescricao", pDescricao);
                objCmd.Parameters["pDescricao"].Direction = ParameterDirection.Input;

                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();
            }
            catch (Exception)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!INSERIR METAS";
                objCnx.Close();
            }
            return retorno;
        }


        public static string spAlterarMetas(string pCodMeta, string pNomeSetor, string pCodfunc, string pDescricao, string pPrazoMeta)
        {
            String retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();

                MySqlCommand objCmd = new MySqlCommand("spAlterarMetas", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pCodMeta", pCodMeta);
                objCmd.Parameters["pCodMeta"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pNomeSetor", pNomeSetor);
                objCmd.Parameters["pNomeSetor"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pCodfunc", pCodfunc);
                objCmd.Parameters["pCodfunc"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pPrazoMeta", pPrazoMeta);
                objCmd.Parameters["pPrazoMeta"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pDescricao", pDescricao);
                objCmd.Parameters["pDescricao"].Direction = ParameterDirection.Input;


                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();

            }
            catch (Exception Erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }


        public static string spCheckarMetas(string pCodMeta, string pPrazo, string pDescricao, string pEntrega, string pJustificativa)
        {
            String retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();

                MySqlCommand objCmd = new MySqlCommand("spCheckarMetas", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pCodMeta", pCodMeta);
                objCmd.Parameters["pCodMeta"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pDescricao", pDescricao);
                objCmd.Parameters["pDescricao"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pPrazo", pPrazo);
                objCmd.Parameters["pPrazo"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pEntrega", pEntrega);
                objCmd.Parameters["pEntrega"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pJustificativa", pJustificativa);
                objCmd.Parameters["pJustificativa"].Direction = ParameterDirection.Input;


                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();

            }
            catch (Exception Erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }


        public static string spInserirGastos(string pCodigoSetor, string pData, string pGasto)
        {
            String retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();


                MySqlCommand objCmd = new MySqlCommand("spInserirGastos", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pCodigoSetor", pCodigoSetor);
                objCmd.Parameters["pCodigoSetor"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pData", pData);
                objCmd.Parameters["pData"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pGasto", pGasto);
                objCmd.Parameters["pGasto"].Direction = ParameterDirection.Input;

                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();

            }
            catch (Exception Erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }// fecha método inserir gastos


        public static string spAlterarGastos(string codGasto, string dataGasto, string valorGasto)
        {
            String retorno = "";
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();

                MySqlCommand objCmd = new MySqlCommand("spAlterarGastos", objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.AddWithValue("pcodigo", codGasto);
                objCmd.Parameters["pcodigo"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pdata", dataGasto);
                objCmd.Parameters["pdata"].Direction = ParameterDirection.Input;

                objCmd.Parameters.AddWithValue("pvalor", valorGasto);
                objCmd.Parameters["pvalor"].Direction = ParameterDirection.Input;

                objCmd.Parameters.Add("retorno", MySqlDbType.VarChar, 50);
                objCmd.Parameters["retorno"].Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();
                retorno = objCmd.Parameters["retorno"].Value.ToString();
                objCnx.Close();
            }
            catch (Exception erro)
            {
                retorno = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
            return retorno;
        }


        public static string fExcluirGastos(string fcodigo)
        {
            String retorno;
            try
            {

                objCnx.Open();
                objCmd.Connection = objCnx;
                objCmd.CommandText = "select fExcluirGastos(" + fcodigo + ") as fExcluirGas;";
                objDados = objCmd.ExecuteReader();
                objDados.Read();
                retorno = objDados["fExcluirGas"].ToString();
                objCnx.Close();
                return retorno;
            }
            catch (Exception)
            {
                return "erro na conexão do bando de dados, contate o administrador!!";
                objCnx.Close();
            }
        }


        public static string fVerificaLogin(string fidUsu, string fsenhaUsu)
        {
            string retorno;
            try
            {
                objCnx.ConnectionString = strConexao;
                objCnx.Open();
                objCmd.Connection = objCnx;
                objCmd.CommandText = "select fVerificaLogin('" + fidUsu + "','" + fsenhaUsu + "') as Login;";
                objDados = objCmd.ExecuteReader();
                objDados.Read();
                retorno = objDados["Login"].ToString();
                objCnx.Close();
                return retorno;
            }
            catch (Exception)
            {
                return "Erro ao conectar com o servidor de dados!, contate o administrador!";
            }
            finally
            {
                objCnx.Close();
            }
        }

        public static string fExcluirUsuario(string fcodUsu)
        {
            String retorno;
            try
            {
               
                objCnx.Open();
                objCmd.Connection = objCnx;
                objCmd.CommandText = "select fExcluirUsuario(" + fcodUsu + ") as fExcluir;";
                objDados = objCmd.ExecuteReader();
                objDados.Read();
                retorno = objDados["fExcluir"].ToString();
                objCnx.Close();
                return retorno;
            }
            catch (Exception)
            {
                return "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
        }


        public static string fExcluirMeta(string fcodMeta)
        {
            String retorno;
            try
            {

                objCnx.Open();
                objCmd.Connection = objCnx;
                objCmd.CommandText = "select fExcluirMeta(" + fcodMeta + ") as fExcluir;";
                objDados = objCmd.ExecuteReader();
                objDados.Read();
                retorno = objDados["fExcluir"].ToString();
                objCnx.Close();
                return retorno;
            }
            catch (Exception)
            {
                return "Erro ao conectar com o servidor de dados!, contate o administrador!";
                objCnx.Close();
            }
        }


        public static string fRetornaNome(string fusuario)
        {
            String retorno;
            try
            {

                objCnx.Open();
                objCmd.Connection = objCnx;
                objCmd.CommandText = "select retornaNome('" + fusuario + "') as fNome;";
                objDados = objCmd.ExecuteReader();
                objDados.Read();
                retorno = objDados["fNome"].ToString();
                objCnx.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                return "Erro ao conectar com o servidor de dados!, contate o administrador!";
            }
            finally
            {
                objCnx.Close();
            }
        }


        //DATA TABLE

        //data grid view consultar usuários
        public DataTable ConsultarUsuarios(string strSQL)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Setor");
                    dtDados.Columns.Add("Usuário");
                    dtDados.Columns.Add("Nome");
                    dtDados.Columns.Add("E-Mail");
                    dtDados.Columns.Add("Telefone");
                    dtDados.Columns.Add("Endereço");
                    dtDados.Columns.Add("CPF");
                    dtDados.Columns.Add("Tipo");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codUsu"].ToString();
                            drRegistro["Setor"] = objDados["codSet"].ToString();
                            drRegistro["Usuário"] = objDados["idUsu"].ToString();
                            drRegistro["Nome"] = objDados["nomePess"].ToString();
                            drRegistro["E-Mail"] = objDados["emailPess"].ToString();
                            drRegistro["Telefone"] = objDados["telPess"].ToString();
                            drRegistro["Endereço"] = objDados["endPess"].ToString();
                            drRegistro["CPF"] = objDados["cpfPess"].ToString();
                            drRegistro["Tipo"] = objDados["tipoUsu"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }
        }//fecha método
              

        public DataTable ConsultarGerGastos(string strSQL)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Data");
                    dtDados.Columns.Add("Valor Gasto");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codDes"].ToString();
                            drRegistro["Data"] = objDados["dataDes"].ToString();
                            drRegistro["Valor Gasto"] = objDados["gastoDes"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }

        }//fecha metodo

        public DataTable ConsultarGastosA(string strSQL)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Setor");
                    dtDados.Columns.Add("Data");
                    dtDados.Columns.Add("Valor Gasto");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codDes"].ToString();
                            drRegistro["Setor"] = objDados["codSet"].ToString();
                            drRegistro["Data"] = objDados["dataDes"].ToString();
                            drRegistro["Valor Gasto"] = objDados["gastoDes"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }

        }//fecha metodo

        public DataTable retornaTBMetasFunc(int aux)
        {
            MySqlDataReader cmdline;
            objCnx.Open();
            objCmd.Connection = objCnx;
            objCmd.CommandText = "SELECT pessUsu.nomePess , pessUsu.codUsu FROM tasksoftbd.pessUsu where tipoUsu = 3 and codSet='" + aux + "' order by nomePess; ";

            cmdline = objCmd.ExecuteReader();

            tbMetas.Load(cmdline);

            cmdline.Close();
            objCnx.Close();

            return tbMetas;
        }

        // datatable metas individuais
        public DataTable MetaIndividual(string strSQL)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Descrição");
                    dtDados.Columns.Add("Prazo");
                    dtDados.Columns.Add("Entrega");
                    dtDados.Columns.Add("Andamento");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codMeta"].ToString();
                            drRegistro["Descrição"] = objDados["descMeta"].ToString();
                            drRegistro["Prazo"] = objDados["prazoMeta"].ToString();
                            drRegistro["Entrega"] = objDados["entregaMeta"].ToString();
                            drRegistro["Andamento"] = objDados["justificativaMeta"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }
        }//fecha método


        // datatable
        public DataTable Consultar(string strSQl)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Funcionário");
                    dtDados.Columns.Add("Prazo"); 
                    dtDados.Columns.Add("Descrição");
                    dtDados.Columns.Add("Entrega");
                    dtDados.Columns.Add("Andamento");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQl;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codMeta"].ToString();
                            drRegistro["Funcionário"] = objDados["nomePess"].ToString();
                            drRegistro["Prazo"] = objDados["prazoMeta"].ToString();
                            drRegistro["Descrição"] = objDados["descMeta"].ToString();
                            drRegistro["Entrega"] = objDados["entregaMeta"].ToString();
                            drRegistro["Andamento"] = objDados["justificativaMeta"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception Erro)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }
        }//fecha método

        //data grid view consultar funcionarios
        public DataTable ConsultarFuncionarios(string strSQL)
        {
            try
            {
                DataTable dtDados = new DataTable();
                if (Conectar())
                {
                    dtDados.Columns.Add("Código");
                    dtDados.Columns.Add("Usuário");
                    dtDados.Columns.Add("Nome");
                    dtDados.Columns.Add("Email");
                    dtDados.Columns.Add("Telefone");
                    dtDados.Columns.Add("Endereço");
                    dtDados.Columns.Add("Cpf");

                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        DataRow drRegistro;
                        while (objDados.Read())
                        {
                            drRegistro = dtDados.NewRow();
                            drRegistro["Código"] = objDados["codUsu"].ToString();
                            drRegistro["Usuário"] = objDados["idUsu"].ToString();
                            drRegistro["Nome"] = objDados["nomePess"].ToString();
                            drRegistro["Email"] = objDados["emailPess"].ToString();
                            drRegistro["Telefone"] = objDados["telPess"].ToString();
                            drRegistro["Endereço"] = objDados["endPess"].ToString();
                            drRegistro["Cpf"] = objDados["cpfPess"].ToString();
                            dtDados.Rows.Add(drRegistro);
                        }
                        if (objDados != null)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }
                    }
                }
                return dtDados;
            }
            catch (Exception Erro)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return null;
            }
            finally
            {
                Desconectar();
            }

        }//fecha metodo

        // executarSql
        public int ExecutarSQL(string strSQL)//operações basicas do mysql
        {
            try
            {
                int lngRetorno = 0;
                if (Conectar())
                {
                    if (objDados != null)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSQL;
                    lngRetorno = objCmd.ExecuteNonQuery();
                }
                return lngRetorno;
            }
            catch (Exception Erro)
            {
                strMsg = "Erro ao conectar com o servidor de dados!, contate o administrador!";
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }//fecha metodooo
    }
}
