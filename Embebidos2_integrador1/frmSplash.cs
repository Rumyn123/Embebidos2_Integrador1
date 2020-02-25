using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embebidos2_integrador1
{
    public partial class frmSplash : Form
    {
        int i = 0;
        public frmSplash()
        {
            InitializeComponent();
            timer.Start();
            btnCarga.Height = 60;
            btnCarga.Width = 0;
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            if(i <= 740)
            {
                i += 5;
                btnCarga.Width = i;
            } else if (i >= 740)
            {
                timer.Stop();
                frmPrincipal pri = new frmPrincipal();
                pri.Show();
                this.Hide();
            }
                
            
            
        }
    }
}
