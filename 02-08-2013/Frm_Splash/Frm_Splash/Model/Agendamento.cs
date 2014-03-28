using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciadordeVendas.ConexaoBD;
using System.Data;

namespace Frm_Splash.Model
{
    class Agendamento
    {
        private String txtLocal;

        public String TxtLocal
        {
            get { return txtLocal; }
            set { txtLocal = value; }
        }

        private String tdAgendamento;

        public String TdAgendamento
        {
            get { return tdAgendamento; }
            set { tdAgendamento = value; }
        }

        private String txtDescricao;

        public String TxtDescricao
        {
            get { return txtDescricao; }
            set { txtDescricao = value; }
        }

        public Boolean salvar()
        {
            String Sql = "insert into agendamento (local, data, descricao) values ('" + txtLocal + "','" + TdAgendamento + "','" + txtDescricao + "')";
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
    }
}
