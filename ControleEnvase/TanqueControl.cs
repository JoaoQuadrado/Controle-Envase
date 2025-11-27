using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEnvase
{
    public partial class TanqueControl : UserControl
    {
        bool arrastando = false;
        Point cliqueInicial;

        public TanqueControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void TanqueControl_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            cliqueInicial = e.Location;
        }

        private void TanqueControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                this.Left += e.X - cliqueInicial.X;
                this.Top += e.Y - cliqueInicial.Y;
            }
        }

        private void TanqueControl_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }
    }
}
