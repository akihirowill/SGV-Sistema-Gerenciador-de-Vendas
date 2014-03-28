using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frm_Splash.Model;

namespace Frm_Splash
{
    public partial class Frm_Agendamento : Form
    {
        public Frm_Agendamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Agendamento ObjAgendamento = new Agendamento();

            if (txtLocal.Text != "" && txtDescricao.Text != "")
            {
                ObjAgendamento.TdAgendamento = dtAgendamento.Text;
                ObjAgendamento.TxtLocal = txtLocal.Text;
                ObjAgendamento.TxtDescricao = txtDescricao.Text;
                ObjAgendamento.salvar();
            }
            else
            {
                MessageBox.Show("Dados do estoque nao foram salvos!\n", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtLocal.Text = "";
            txtDescricao.Text = "";

        }

        private void dtAgendamento_ValueChanged(object sender, EventArgs e)
        {

        }


 
    }
}
