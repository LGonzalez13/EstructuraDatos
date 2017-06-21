using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyCarrera
{
    class Corredor
    {
        static Random r = new Random();
        private int _posicion;
        public int posicion { get { return _posicion; } }

        public Corredor()
        {
            _posicion = 0;
        }

        public void correr()
        {
            _posicion += yardasRecorridas();
        }

        private int yardasRecorridas()
        {
            int n = r.Next(7);
            if (n < 2)
                return 3;
            else if (n > 1 && n < 5)
                return 2;
            else
                return 1;
        }
    }
}
