using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proySerpientesEscaleras
{
    class Jugador
    {
        private static Random dado = new Random();
        private int _pos;
        public int pos { get { return _pos; } }
        private string _nombre;
        public string nombre { get { return _nombre; } }

        public Jugador(string n)
        {
            _pos = 0;
            _nombre = n;
        }

        public int lanzar()
        {
            return dado.Next(1,7);
        }

        public void avanzar(int poscision)
        {
            _pos = poscision;
        }
    }
}
