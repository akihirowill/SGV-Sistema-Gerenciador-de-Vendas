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
    public partial class Frm_Vendas : Form
    {
        int Qtdvenda = 0, celula, nro, qtd;
        float din, total, troco, din2, valor;



        public Frm_Vendas()
        {
            InitializeComponent();
            atualizaGrid();
            nudQtd.Value = 1;
        }


        private void dgrEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celula = Convert.ToInt16(dgrEstoque.CurrentRow.Index);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int recebe;

            recebe = Convert.ToInt16(dgrEstoque.CurrentRow.Cells[3].Value);
            nro = Convert.ToInt16(dgrEstoque.CurrentRow.Cells[3].Value);

            if(nro > recebe)
                {
                    MessageBox.Show("A quantidade em estoque é menor que a quantidade que esta sendo vendida.", "Sistema Gerenciador de Vendas",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else                
                {
                    //incrementando as vendas
                    dgrVendas.RowCount += 1;

                    //colocando os produtos do estoque no lugar da venda
                    dgrVendas.Rows[Qtdvenda].Cells[0].Value = dgrEstoque.Rows[celula].Cells[0].Value;
                    dgrVendas.Rows[Qtdvenda].Cells[1].Value = dgrEstoque.Rows[celula].Cells[1].Value;
                    dgrVendas.Rows[Qtdvenda].Cells[2].Value = dgrEstoque.Rows[celula].Cells[2].Value;
                    //quantidade de produtos que vao ser vendidos
                    dgrVendas.Rows[Qtdvenda].Cells[3].Value = nudQtd.Value;



                    //passando o valor da compra para o total
                    valor = Convert.ToSingle(dgrVendas.Rows[Qtdvenda].Cells[2].Value);
                    qtd = Convert.ToInt16(nudQtd.Value);
                    total = total + (qtd * valor);

                    lbl_total.Text = total.ToString("#.#0");


                    //incrementando a quantidade de produtos
                    Qtdvenda++;
                }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                din2 = Convert.ToSingle(txtDinheiro.Text);
                troco = din2 - total;
                lblTroco.Text = troco.ToString("#0.#0");
            }
            catch
            {

            }
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            //troca o '.' por ','.
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtDinheiro.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 
            }

            //Verífica os caracteres inseridos
            else if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 44)
            {
                e.Handled = true;
            }
        }

        private void atualizaGrid()
        {
            try
            {
                dgrEstoque.DataSource = Estoque.pesquisaTudo();
                dgrEstoque.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int compara, retira, recebe;



            if (dgrVendas.RowCount == 0)
                MessageBox.Show("Não Existem Produtos Para Remover da Lista");

            else
            {
                valor = Convert.ToSingle(dgrVendas.CurrentRow.Cells[2].Value);

                compara = Convert.ToInt16(dgrVendas.CurrentRow.Cells[3].Value);

                retira = Convert.ToInt16(dgrVendas.CurrentRow.Cells[3].Value);
                qtd = Convert.ToInt16(nudQtd.Value);


                    if (nudQtd.Value == compara)
                    {
                        
                        total = total - (qtd * valor);
                        lbl_total.Text = total.ToString("#0.#0");
                        dgrVendas.Rows.Remove(dgrVendas.Rows[dgrVendas.CurrentRow.Index]);
                        Qtdvenda--;
                    }
                    else
                        if (nudQtd.Value < compara)
                        {
                            qtd = Convert.ToInt16(nudQtd.Value);
                            recebe = (retira - qtd);
                            dgrVendas.CurrentRow.Cells[3].Value = recebe;


                            total = total - (qtd * valor);

                            lbl_total.Text = total.ToString("#0.#0");
                         }
            }
                            
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vendas ObjVendas = new Vendas();
                    
            int i,id,quantidade;
            lbldata.Text = DateTime.Now.ToShortDateString();
            ObjVendas.Lbldata = lbldata.Text;
            ObjVendas.IntStatus = 0;
            ObjVendas.salvardatavenda();

            DataTable dtaIdVenda = new DataTable();

            dtaIdVenda = ObjVendas.buscarIdVenda(lbldata.Text);

            for (i = 0; i < Qtdvenda; i++)
            {
                ObjVendas.IntIdVenda = Convert.ToInt16(dtaIdVenda.Rows[0][0]);
                ObjVendas.LblId = Convert.ToInt16(dgrVendas.Rows[i].Cells[0].Value);
                ObjVendas.Lblqtd = Convert.ToInt16(dgrVendas.Rows   [i].Cells[3].Value);

                ObjVendas.salvar();
            }

            ObjVendas.atualizarStatus(Convert.ToInt16(dtaIdVenda.Rows[0][0]));
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgrEstoque.DataSource = Estoque.buscarTodosFiltro(txtConsulta.Text);
            dgrEstoque.Columns[0].Visible = false;

        }
    }
}

