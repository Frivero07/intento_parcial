using System.Runtime.CompilerServices;
using Tienda_Electrodomesticos.Modelos;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("juan",486485654,"123");
        Producto producto1 = new Producto ("asdasd",150,"asdasds");
        Venta venta1 = new Venta(DateTime.Now,producto1,10,cliente);
        producto1.MostrarDetalles();
        cliente.MostrarCliente();
        venta1.MostrarVenta();
        venta1.CalcularTotal();
    }
}
