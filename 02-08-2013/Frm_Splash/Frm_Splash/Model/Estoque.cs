using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciadordeVendas.ConexaoBD;
using System.Data;

namespace Frm_Splash.Model
{
    class Estoque
    {
        private int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        private String lbldata;

        public String Lbldata
        {
            get { return lbldata; }
            set { lbldata = value; }
        }
        
        private String txtPreco;

        public String TxtPreco
        {
            get { return txtPreco; }
            set { txtPreco = value; }
        }

        private Int32 nudQuantidade;
        public Int32 NudQuantidade
        {
            get { return nudQuantidade; }
            set { nudQuantidade = value; }
        }
        
        //método para salvar dados no BD
        public Boolean salvar()
        {
            String Sql = "insert into estoque (id_produto, quantidade, preco, data) values (" + idProduto +", " + nudQuantidade + ",'" + txtPreco + "','" + lbldata + "')"; 
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


        
             public static DataTable buscarTodos()
        {
            String sql = "select produto.nome as Produto, estoque.preco as Preco, estoque.quantidade as Quantidade from produto, estoque where produto.id = estoque.id_produto order by produto.nome";
            return BancodeDados.GetInstancia().Consultar(sql);
                            
        }
             
        
            public static DataTable buscarProdutosVenda()
        {
                 String sql = "select produto.id,produto.nome as Produto, estoque.preco as Preco, estoque.quantidade as Quantidade from produto, estoque order by nome";
                 return BancodeDados.GetInstancia().Consultar(sql);

        }

             public DataTable atualizar()
             {
                 String sql = "update estoque set quantidade = quantidade + " + NudQuantidade + " where id_produto = " + idProduto + " and preco = '" + txtPreco + "'";
                 return BancodeDados.GetInstancia().Consultar(sql);
             }

             public DataTable procura(Int32 intProduto, String strPreco)
             {
                 String sql = "select count(id_produto) as contador from estoque where id_produto = " + intProduto + " and preco = '" + strPreco + "'";
                 return BancodeDados.GetInstancia().Consultar(sql);
             }

             public static DataTable filtroID(int filtro)
             {
                 String sql = "select nome, id from produto order by nome where id_produto = " + filtro;
                 return BancodeDados.GetInstancia().Consultar(sql);
             }

             public static DataTable pesquisaTudo()
             {
                 String sql = "select e.id_produto, p.nome, e.preco, e.quantidade from estoque e, produto p where e.id_produto = p.id";
                 return BancodeDados.GetInstancia().Consultar(sql);
             }

             public static DataTable buscarTodosFiltro(string filtro)
             {
                 String sql = "select e.id_produto, p.nome, e.preco, e.quantidade from estoque e, produto p  where e.id_produto = p.id and p.nome  like '%"+ filtro +"%' order by e.id_produto";
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
