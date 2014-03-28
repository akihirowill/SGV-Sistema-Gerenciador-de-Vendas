using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGerenciadordeVendas.Resources;
using Frm_Splash.Model;


namespace Frm_Splash
{
    public partial class frm_EntradaDeProduto : Form
    {
        int qtd;
        public frm_EntradaDeProduto()
        {
            InitializeComponent();
            atualizaGrid();
            atualizaNome();
        }

        private void atualizaNome()
        {
            try
            {
                cb_Produto.DataSource = Produto.pesquisaTudo();
                cb_Produto.DisplayMember = "nome";
                cb_Produto.ValueMember = "id";
                cb_Produto.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
        private void atualizaGrid()
        {
            try
            {
               dgr_lista.DataSource = Estoque.pesquisaTudo();
               dgr_lista.Columns[0].Visible = false;
               dgr_lista.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int armazena;
        
        private void dgr_lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_Produto.Text = dgr_lista.Rows[e.RowIndex].Cells[1].Value.ToString();
            armazena = Convert.ToInt16(dgr_lista.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Estoque ObjEstoque = new Estoque();
            
            DataTable recebe;
            int qtdeRegistros = 0;

            lbldata.Text = DateTime.Now.ToShortDateString();
            
            recebe = ObjEstoque.procura(Convert.ToInt32(cb_Produto.SelectedValue), txt_preco.Text);

            qtdeRegistros = Convert.ToInt16(recebe.Rows[0]["contador"]);

            if (nudQtd.Value != 0 && cb_Produto.Text != "" && txt_preco.Text != "")
            {
                ObjEstoque.IdProduto = armazena;
                ObjEstoque.Lbldata = lbldata.Text;
                ObjEstoque.TxtPreco = txt_preco.Text;
                ObjEstoque.NudQuantidade = Convert.ToInt32(nudQtd.Value);

                if (qtdeRegistros > 0)
                {
                    ObjEstoque.atualizar();
                    
                    atualizaGrid();
                    
                }
                else
                {
                    ObjEstoque.salvar();
                    atualizaGrid();
                }
            }
            else
            {
                MessageBox.Show("Dados do estoque nao foram salvos!\n", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgr_lista.DataSource = Estoque.buscarTodosFiltro(txtConsulta.Text);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               armazena = Convert.ToInt16(cb_Produto.SelectedValue.ToString());
            }
            catch
            { 

            }

        }  

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txt_preco.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 
            }

            //Verífica os caracteres inseridos
            else if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 44)
            {
                e.Handled = true;
            }
        }

    }
}
