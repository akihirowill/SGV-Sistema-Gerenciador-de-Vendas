using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciadordeVendas.ConexaoBD;
using System.Data;


namespace Frm_Splash.Model
{
    class Vendas
    {
        private String lbldata;

        public String Lbldata
        {
            get { return lbldata; }
            set { lbldata = value; }
        }

        private int intIdVenda;

        public int IntIdVenda
        {
            get { return intIdVenda; }
            set { intIdVenda = value; }
        }

        private int lblqtd;

        public int Lblqtd
        {
            get { return lblqtd; }
            set { lblqtd = value; }
        }

        private int lblId;

        public int LblId
        {
            get { return lblId; }
            set { lblId = value; }
        }

        private int intStatus;

        public int IntStatus
        {
            get { return intStatus; }
            set { intStatus = value; }
        }

        public Boolean salvar()
        {
            String Sql = "insert into saida(id_venda, id_produto, qtd_vendida) values(" + intIdVenda + ", " + lblId + ", " + lblqtd + ")";
            //BancodeDados.GetInstancia().Salvar(Sql); 
            /*mudanca de codigo - Elis (antes, a chamada do metodo GetInstancia e Salvar nao estavam dentro
            de um try catch. Colocando a chamada dentro de um try catch, é possível retornar true ou false.
            Dessa forma, é possivel saber, no frmAluno, se os dados foram inseridos no Banco de Dados ou não.
            */
            try
            {
                BancodeDados.GetInstancia().Salvar(Sql);
                return true;
            }
            catch (Exception ex)
            {
                int i = 0;
                throw new Exception(ex.Message);
                //return false;
            }
        }

        public Boolean atualizarStatus(int intIdVenda)
        {
            String sql = "update vendas set status = 1 where id_venda = " + intIdVenda;

            try
            {
                BancodeDados.GetInstancia().Salvar(sql);
                return true;
            }
            catch (Exception ex)
            {
                int i = 0;
                throw new Exception(ex.Message);
                //return false;
            }
        }

        public Boolean salvardatavenda()
        {
            String Sql = "insert into vendas (data, status) values('" + Lbldata + "', " + intStatus + ")";
            //BancodeDados.GetInstancia().Salvar(Sql);
            /*mudanca de codigo - Elis (antes, a chamada do metodo GetInstancia e Salvar nao estavam dentro
            de um try catch. Colocando a chamada dentro de um try catch, é possível retornar true ou false.
            Dessa forma, é possivel saber, no frmAluno, se os dados foram inseridos no Banco de Dados ou não.
            */
            try
            {
                BancodeDados.GetInstancia().Salvar(Sql);
                return true;
            }
            catch (Exception ex)
            {
                int i = 0;
                throw new Exception(ex.Message);
                //return false;
            }
        }

        public DataTable buscarIdVenda(String strData)
        {
            String sql = "select id_venda from vendas where data = '" + strData + "' and status = 0";

            return BancodeDados.GetInstancia().Consultar(sql);
        }

        public static DataTable buscarTodosFiltro(string filtro)
        {
            String sql = "select e.id_produto, p.nome, e.preco, e.quantidade from estoque e, produto p  where e.id_produto = p.id and p.nome  like '%" + filtro + "%' order by e.id_produto";
            try
            {
                return BancodeDados.GetInstancia().Consultar(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
        }
    }
}