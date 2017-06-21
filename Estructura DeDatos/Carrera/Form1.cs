using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyCarrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorrrer_Click(object sender, EventArgs e)
        {
            Corredor c1 = new Corredor();
            Corredor c2 = new Corredor();

            while (c1.posicion < 100 && c2.posicion < 100)
            {
                c1.correr();
                c2.correr();
                
                txtCarrera.Text += "Corredor 1 -> " + c1.posicion.ToString() + "   Corredor 2 -> " + c2.posicion.ToString() + Environment.NewLine;
            }
        }
    }
}
