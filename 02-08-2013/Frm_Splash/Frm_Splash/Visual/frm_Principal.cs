using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Splash
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroDePodutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estoque CadastroEstoque = new Frm_Estoque();
            CadastroEstoque.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Sobre formSobre = new frm_Sobre();
            formSobre.ShowDialog();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agendamentoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EntradaDeProduto formentrada = new frm_EntradaDeProduto();
            formentrada.ShowDialog();
        }

        private void tmr_DataeHora_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToShortDateString();
            lbl_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void novoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Agendamento formAgendamento = new Frm_Agendamento();
            formAgendamento.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vendas formVendas = new Frm_Vendas();
            formVendas.ShowDialog();
        }

        private void conexaoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conexaoBD formConexaoBD = new frm_conexaoBD();
            formConexaoBD.ShowDialog();
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

 

    }
}
