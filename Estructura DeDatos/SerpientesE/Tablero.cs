using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proySerpientesEscaleras
{
    class Tablero
    {
        private int[] tablero;

        public Tablero()
        {
            tablero = new int[100];
            for (int i = 0; i < 100; i++)
                tablero[i] = i;

            //Escaleras
            tablero[3] = 8;
            tablero[10] = 30;
            tablero[18] = 24;
            tablero[27] = 35;
            tablero[37] = 48;
            tablero[48] = 59;
            tablero[60] = 66;
            tablero[65] = 79;
            tablero[73] = 78;
            tablero[80] = 90;

            //Serpientes
            tablero[11] = 4;
            tablero[21] = 9;
            tablero[25] = 12;
            tablero[38] = 20;
            tablero[45] = 38;
            tablero[50] = 32;
            tablero[64] = 48;
            tablero[77] = 70;
            tablero[89] = 69;
            tablero[96] = 83;
        }

        public int validar(int casilla)
        {
            return tablero[casilla];
        }
    }
}
