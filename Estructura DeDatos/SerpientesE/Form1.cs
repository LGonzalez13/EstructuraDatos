using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proySerpientesEscaleras
{
    public partial class Form1 : Form
    {
        Tablero T;
        Jugador J1;
        Jugador J2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            T = new Tablero();
            J1 = new Jugador(txtJ1.Text);
            J2 = new Jugador(txtJ2.Text);
            string ganador = "";
            int dado = 0;

            while (J1.pos < 100 && J2.pos < 100)
            {
                dado = J1.lanzar();
                if (J1.pos + dado < 100)
                {
                    J1.avanzar(T.validar(J1.pos + dado));
                }
                else
                {
                    ganador = J1.nombre;
                    break;
                }

                dado = J2.lanzar();
                if (J2.pos + dado < 100)
                {
                    J2.avanzar(T.validar(J2.pos + dado));
                }
                else
                {
                    ganador = J2.nombre;
                    break;
                }
            }

            txtGanador.Text = ganador;
        }
    }
}
