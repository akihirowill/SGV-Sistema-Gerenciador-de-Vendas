using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Frm_Splash
{
    public partial class SGV : Form
    {
        public SGV()
        {
            InitializeComponent();
        }

        private void TmrSplash_Tick(object sender, EventArgs e)
        {
            if (Prb_Status.Value < 100)
                Prb_Status.Value = Prb_Status.Value += 1;
            else
            {
               
                TmrSplash.Enabled = false;
                this.Visible = false;

                FrmPrincipal TelaPrincipal = new FrmPrincipal();
                TelaPrincipal.ShowDialog();
            }
        }
    }
}
