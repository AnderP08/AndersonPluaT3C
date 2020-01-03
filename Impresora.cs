using System;
namespace CarritoDeCompras
{
    public class Impresora
    {
        public Impresora()
        {
        }

        /*
         Dependencia unica
         Imprimir datos del cliente
         */

        public void ImprimirDatosCliente(ICliente cliente)
        { 
            Console.WriteLine(cliente.Apellidos() + cliente.Nombres());

            //return cliente.Nombres + " " + cliente.Apellidos;   
        }
    }
}
