using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyControlInv
{
    class Inventario
    {
        private Producto primero;
        private int numeroProductos;
        
        public Inventario()
        {
            numeroProductos = 0;
        }

        public void agregar(Producto p)
        {
            
            if(primero==null)
            {
                primero = p;
            }
            else
            {
                Producto temp = primero;
                if (p.codigo < primero.codigo)
                {
                    primero = p;
                    p.quienSigue = temp;
                }
                else
                {
                    while (temp.quienSigue != null && p.codigo > temp.quienSigue.codigo)
                    {
                        temp = temp.quienSigue;
                    }
                    p.quienSigue = temp.quienSigue;
                    temp.quienSigue = p;
                }
                
            }
            numeroProductos++;
                
        }

        public Producto buscar(string nombre)
        {
            Producto temp = primero;
            while (temp != null && temp.nombre != nombre)
            {
                temp = temp.quienSigue;
            }
            return temp;

        }

        public void eliminar(string nombre)
        {
            Producto temp = primero;
            while (temp.quienSigue.nombre != nombre)
            {
                temp = temp.quienSigue;
            }
            temp.quienSigue = temp.quienSigue.quienSigue;
        }

        public string reporte()
        {
            Producto temp = primero;
            string reporte = temp.ToString() + Environment.NewLine + Environment.NewLine;
            while (temp.quienSigue != null)
            {
                reporte += temp.quienSigue.ToString() + Environment.NewLine + Environment.NewLine;
                temp = temp.quienSigue;
            }
            return reporte;
        }

        public void insertar(Producto p, int pos)
        {
            Producto temp = primero;
            int i = 1;
            while (i<pos)
            {
                temp = temp.quienSigue;
                i++;
            }
            p.quienSigue = temp.quienSigue;
            temp.quienSigue = p;
        }

        public override string ToString()
        {
            return numeroProductos.ToString();
        }
    }
}
