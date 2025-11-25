using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEnvase
{
    internal class Cls_Uteis
    {
        public static double Conversor (TextBox txt)
        {
            double valor;
            double.TryParse(txt.Text, out valor);
            return valor;
        }
    }
}
