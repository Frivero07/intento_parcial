using System;


namespace Tienda_Electrodomesticos.Modelos
{
    public class Cliente
    {
      public string Nombre { get; private set; }
      public double Telefono { get; private set; }

      public string Codigo { get; private set; }

        public Cliente (string nombre, double telefono,string codigo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;
        }
        public void  MostrarCliente()
        {
            Console.WriteLine($"El nombre del cliente es {Nombre}" +
                $"El telefono es {Telefono}" +
                $"El codigo es {Codigo}");
        }

    }
}
