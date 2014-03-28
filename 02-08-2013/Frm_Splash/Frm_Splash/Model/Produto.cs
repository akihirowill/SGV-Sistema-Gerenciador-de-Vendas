using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciadordeVendas.ConexaoBD;
using System.Data;

namespace Frm_Splash.Model
{
    class Produto
    {
        private string strIdProduto;

        public string StrIdProduto
        {
          get { return strIdProduto; }
          set { strIdProduto = value; }
        }

        private string txtProduto;

        public string TxtProduto
        {
            get { return txtProduto; }
            set { txtProduto = value; }
        }

               //método para salvar dados no BD
        public Boolean salvar()
        {
            String Sql = "insert into produto (nome) values ('" + txtProduto + "')"; 
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

        public Boolean editar()
        {
            String sql = "update produto set nome='" + TxtProduto +  "'where id=" + StrIdProduto + "";
            
            try
            {
                BancodeDados.GetInstancia().Salvar(sql);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //return false;
            }
        }

        public Boolean apagar()
        {
            String sql = "delete from produto where id=" + strIdProduto;

            try
            {
                BancodeDados.GetInstancia().Salvar(sql);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                //return false;
            }

        }

       
        public static DataTable pesquisaTudo()
        {
            String sql = "select id, nome from produto order by nome";
            return BancodeDados.GetInstancia().Consultar(sql);
        }

        public static DataTable buscarTodosFiltro(string filtro)
        {
            String sql = "select * from produto where nome like '%" + filtro + "%' order by id";
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
