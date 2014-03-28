using System;
using System.Windows.Forms;
using System.Xml;
using Npgsql;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using Microsoft.Win32;
using SistemaEscola.Resources;

namespace SistemaEscola.ConexaoBD
{
    /// <summary>
    /// Classe responsavel pela conexão do BD
    /// </summary>
    public class BancodeDados
    {
        /// <summary>
        /// Conexão
        /// </summary>
        public NpgsqlConnection objConexao;

        /// <summary>
        /// Instancia para o padrão Singleton
        /// </summary>
        private static BancodeDados instancia;

        /// <summary>
        /// DataSet e Adapter
        /// </summary>
        private NpgsqlDataAdapter objAdapter;
        private DataSet objDataSet;

        /// <summary>
        /// Variaveis que formam a string de conexão
        /// </summary>
        private readonly String strServidor, strPorta, strLogin, strSenha, strBancoDados, strConexao;

        /// <summary>
        /// Obter mensagem de erro
        /// </summary>
        private String strErro;

        /// <summary>
        /// Obter erros gerados
        /// </summary>
        /// <returns>string erro</returns>
        public String GetErro()
        {
            return strErro;
        }

        /// Chave utilizada na criptografia DES.
        /// </summary>
        //     private static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("GFSQLite");

        /// <summary>
        /// Utilizando padrao Singleton
        /// </summary>
        /// <returns></returns>
        public static BancodeDados GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new BancodeDados();
            }
            return instancia;
        }

        /// <summary>
        /// Construtor da classe: Obter os dados via Registro e estabelecer conexão com o banco
        /// </summary>
        private BancodeDados()
        {
            try
            {
                Registro objReg = new Registro();
                strServidor = objReg.getValor("Servidor");
                strPorta = objReg.getValor("Porta");
                strLogin = objReg.getValor("Login");
                strSenha = objReg.getValor("Senha");
                strBancoDados = objReg.getValor("Banco");

                /*strServidor = "localhost";
                strPorta = "5432";
                strLogin = "postgres";
                strSenha = "admin";
                strBancoDados = "SistemaEscola";
                */

                strConexao = "Server=" + strServidor + ";" +
                                "Port=" + strPorta + ";" +
                                "User Id=" + strLogin + ";" +
                                "Password=" + strSenha + ";" +
                                "Database=" + strBancoDados + ";Timeout=300;CommandTimeout=300";

                objConexao = new NpgsqlConnection(strConexao);
            }
            catch (Exception e)
            {
                strErro = e.Message;

                throw new Exception("Erro na Conexão: " + strErro);
            }
        }

        /// <summary>
        /// Testa conexão com banco de dados
        /// </summary>
        /// <returns>retorna true se a conexao foi estabelecida, caso contrario retorna false</returns>
        public bool TestaConexao()
        {
            try
            {
                objConexao = new NpgsqlConnection(strConexao);
                objConexao.Open();
                objConexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                strErro = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Metodo para persistir um comando sql no banco
        /// </summary>
        /// <param name="sql">comando sql a ser introduzido</param>
        /// <returns>retorna true se a persistencia ocorreu normalmente, caso contrario retorna false</returns>
        public Int32 Salvar(String sql)
        {
            try
            {
                objConexao.Open();
                NpgsqlCommand exec = new NpgsqlCommand(sql, objConexao);
                Int32 rows = exec.ExecuteNonQuery();
                objConexao.Close();
                return rows;
            }
            catch (Exception ex)
            {
                // mudanca no codigo - Elis (antes era objConexao.Close(), agora chamo o metodo desconectar()
                //objConexao.Close();

                desconectar();
                strErro = ex.Message;
                throw new Exception("Erro na conexão com o Banco de Dados. \n" + ex.Message);
                //return 0;
            }
        }

        /// <summary>
        /// Metodo para persistir um comando sql no banco
        /// </summary>
        /// <param name="sql">comando sql a ser introduzido</param>
        /// <returns>retorna true se a persistencia ocorreu normalmente, caso contrario retorna false</returns>
        public Object PersistirRetID(String sql)
        {
            try
            {
                objConexao.Open();
                NpgsqlCommand exec = new NpgsqlCommand(sql, objConexao);
                Object rows = exec.ExecuteScalar();
                objConexao.Close();
                return rows;
            }
            catch (Exception)
            {
                objConexao.Close();
                return 0;
            }
        }

        public void ExportarArquivo(string sql)
        {
            //objConexao.Open();
            objConexao = new NpgsqlConnection(strConexao);
            NpgsqlCommand exec = new NpgsqlCommand(sql, objConexao);
            exec.Connection.Open();
            exec.ExecuteNonQuery();
            exec.Connection.Close();
            //objConexao.Close();
        }

        /// <summary>
        /// Metodo para persistir os dados considerando que a conexao ja esta aberta
        /// Utilizado nas operações TRANSACTIONS
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        public void PersistirTransaction(string sql)
        {
            NpgsqlCommand exec = new NpgsqlCommand(sql, objConexao);
            exec.ExecuteNonQuery();
        }

        /// <summary>
        /// Faz a consulta no banco 
        /// </summary>
        /// <param name="sql">Comando sql responsavel pela consulta</param>
        /// <returns>Retorna os dados da consulta em um DataTable</returns>
        public DataTable Consultar(String sql)
        {
            DataTable objDataTable = new DataTable();

            try
            {

                objConexao.Open();
                if (objConexao.State == ConnectionState.Open)
                {

                    objAdapter = new NpgsqlDataAdapter(sql, objConexao);
                    objDataTable.Clear();
                    objAdapter.Fill(objDataTable);
                    objConexao.Close();
                }
                return objDataTable;
            }
            catch (Exception e)
            {
                objConexao.Close();
                throw new Exception("Erro na consulta: " + e.Message + "\n\nVerifique se a os dados para conexão com o Banco de Dados estão corretos!");
            }
        }

        public void desconectar()
        {
            try
            {
                objConexao.Close();
                instancia = null;
            }
            catch (Exception e)
            {
                throw new Exception("Erro na consulta: " + e.Message + "\n\nVerifique se a os dados para conexão com o Banco de Dados estão corretos!");
            }
        }


    }
}
