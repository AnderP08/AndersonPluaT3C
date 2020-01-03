using System;
namespace CarritoDeCompras
{
    public interface ICliente
    {
        /*PRINCIPIO SEGREGACION DE INTERFACES
        */

        string Cedula();
        string Nombres();
        string Apellidos();
        string Email();
        string Contrasena();

        //public Cliente()
        //{

        //}
        //PROPIEDADES
        //public string Cedula { get; set; }
        //public string Nombres { get; set; }
        //public string Apellidos { get; set; }
        //public string Email { get; set; }
        //public string Contrasena { get; set; }


    }
}
