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
    public partial class Frm_Estoque : Form
    {
        //criando uma variavel global para a quantidade de produtos no estoque

        int intQtdEstoque = 0;
        private String strIdProduto;
        private String strMensagem = "";

        //uso essa variavel pra saber se estou criando um novo ou 
        //editando um registro que ja existia
        private bool boEhNovo = true;

        //uso essa variavel enum para controlar os botoes da interface
        private enum estadoInterface { mostrarNovo, esconderNovo };

        //construtor do form

        public Frm_Estoque()
        {
            InitializeComponent();
            atualizaGrid();
            atualizaBotoes(estadoInterface.esconderNovo);
        }

        private void atualizaBotoes(estadoInterface control)
        {
            if (control == estadoInterface.esconderNovo)
            {
                btnAlterar.Enabled = false;
                btnFechar.Enabled = false;
                btnNovo.Enabled = false;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                txtProduto.Enabled = true;
                dgrProduto.Enabled = false;

                
            }
            else
            {
                btnAlterar.Enabled = true;
                btnFechar.Enabled = true;
                btnNovo.Enabled = true;
                btnDeletar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                txtProduto.Enabled = false;
                dgrProduto.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            boEhNovo = true;
            atualizaBotoes(estadoInterface.esconderNovo);
            txtCodigo.Text = "";
            txtProduto.Text = "";

        }

        private void atualizaGrid()
        {
            try
            {
                dgrProduto.DataSource = Produto.pesquisaTudo();
                dgrProduto.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao recuperar dados da tabela Produto/n" + ex.Message);
            }

        }

        private void dgrEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgrProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dgrProduto.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Tem certeza que deseja exlcuir esse Produto?", "Aviso", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Produto objProduto = new Produto();
                objProduto.StrIdProduto = strIdProduto;
                objProduto.apagar();
                atualizaGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            atualizaBotoes(estadoInterface.mostrarNovo);
            txtCodigo.Text = "";
            txtProduto.Text = "";

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeletar_Click(null, null);

        }

        private void dgrEstoque_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            strIdProduto = dgrProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCodigo.Text = dgrProduto.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtProduto.Text = dgrProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgrEstoque_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            strIdProduto = dgrProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgrProduto.DataSource = Vendas.buscarTodosFiltro(txtConsulta.Text);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            boEhNovo = false;
            atualizaBotoes(estadoInterface.esconderNovo);
            txtCodigo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto ObjProduto = new Produto();
            Estoque ObjEstoque = new Estoque();

            ObjProduto.TxtProduto = txtProduto.Text;

            if (txtProduto.Text != "")

                try
                {
                    if (boEhNovo == true)
                    {
                        ObjProduto.salvar();
                    }
                    else
                    {
                        ObjProduto.StrIdProduto = strIdProduto;
                        ObjProduto.editar();
                    }
                
                atualizaBotoes(estadoInterface.mostrarNovo);
                atualizaGrid();
                //gerarEstoque();

                }
                catch (Exception erro)
                {
                    strMensagem = "Erros encontrados: " + strMensagem;
                    MessageBox.Show(this, strMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                     txtCodigo.Text = "";
                     txtProduto.Text = "";
                     txtProduto.Focus();
                     atualizaGrid();
                     atualizaBotoes(estadoInterface.mostrarNovo);

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAlterar_Click(null, null);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

        }


       
    }
}
