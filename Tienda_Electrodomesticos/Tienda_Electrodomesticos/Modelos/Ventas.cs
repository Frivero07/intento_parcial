

using System.Threading.Channels;
using System.Xml;

namespace Tienda_Electrodomesticos.Modelos
{
    public class Venta 
    {
        public DateTime Fecha { get; private set; }
        private Producto _productovendido;
        public int Cantidad { get; private set; }
        public Cliente Cliente { get; private set; }
        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            this.Fecha = fecha;
            _productovendido = productoVendido;
            Cantidad = cantidad;
            Cliente = cliente;

        }
        public Producto ProductoVendido
        {
            get { return _productovendido; }
            set { _productovendido = value; }
        }
        public double CalcularTotal()

        {
            double total = 0;
            if (Cantidad <= 0)
            {
                Console.WriteLine("cantidad negativa");
            }
            else
            {
                total += Cantidad;
            }

            return total;
        }
        public void MostrarVenta()
        {
            Console.WriteLine($"La fecha es {this.Fecha}" +
                $"El producto es {_productovendido}" +
                $"La cantidad es {Cantidad}" +
                $"El cliente es {Cliente}");
        }
               


    }
}

