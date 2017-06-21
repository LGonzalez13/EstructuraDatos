using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyControlInv
{
    class Producto
    {
        //codigo, nombre, cantidad, costo, quienSigue
        private int _codigo;
        public int codigo { get { return _codigo; } }

        private string _nombre;
        public string nombre { get { return _nombre; } }

        private int _cantidad;
        public int cantidad { get { return _cantidad; } }

        private int _costo;
        public int costo { get { return _costo; } }

        private Producto _quienSigue;
        public Producto quienSigue { get { return _quienSigue; } set { _quienSigue = value; } }

        public Producto(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
            _quienSigue = null;
        }

        public override string ToString()
        {
            return codigo.ToString() + Environment.NewLine + nombre + Environment.NewLine + cantidad.ToString() + " pza(s)" + Environment.NewLine + "$" + costo.ToString();
        }
    }
}
