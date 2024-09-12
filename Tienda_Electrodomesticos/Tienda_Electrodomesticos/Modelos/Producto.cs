using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electrodomesticos.Modelos
{
    public  class Producto
    {
        public string Nombre { get; private set; }
        private double _precio;
        public string Codigo { get; private set; }
        public Producto(string nombre, double precio,string codigo)
        {
            Nombre = nombre;
            _precio = precio;
            Codigo = codigo;
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"El nombre del producto es {Nombre}" +
                $"El precio es {Precio}" +
                $"El codigo es {Codigo}");
        }

    }
}
