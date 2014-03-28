using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaGerenciadordeVendas.ConexaoBD;
using SistemaGerenciadordeVendas.Resources;

namespace Frm_Splash
{
    public partial class frm_conexaoBD : Form
    {
        public frm_conexaoBD()
        {
            InitializeComponent();
        }
        
        private void frm_conexaoBD_Load(object sender, EventArgs e)
        {

        }

        private void salvarDadosRegistro()
        {
            //criar objeto do tipo registrob
            Registro objReg = new Registro();
            objReg.setValor("Servidor", txtServidor.Text);
            objReg.setValor("Login", txtUsuario.Text);
            objReg.setValor("Senha", txtSenha.Text);
            objReg.setValor("Banco", txtBD.Text);
            objReg.setValor("Porta", txtPortaConexao.Text);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }


        private void btnTestar_Click(object sender, EventArgs e)
        {
            String strMsg;
            salvarDadosRegistro();
            BancodeDados.GetInstancia().desconectar();

            if (BancodeDados.GetInstancia().TestaConexao())
                strMsg = "Conexão estabelecida com sucesso!";
            else
                strMsg = "Erro na conexão: " + BancodeDados.GetInstancia().GetErro();

            MessageBox.Show(this, strMsg, "Aviso");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
