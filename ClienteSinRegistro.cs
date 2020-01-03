using System;
namespace CarritoDeCompras
{
    public class ClienteSinRegistro : ICliente, IDescuento, ITelefono
    {
        public string Apellidos()
        {
            throw new NotImplementedException();
        }
        public string Cedula()
        {
            throw new NotImplementedException();
        }
        public string Contrasena()
        {
            throw new NotImplementedException();
        }

        /*PRINCIPIO SUSTITUCION DE LISKOV
            EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
        */
        public decimal Descuento()
        {
            throw new NotImplementedException();
        }

        public string Email()
        {
            throw new NotImplementedException();
        }
        public string Nombres()
        {
            throw new NotImplementedException();
        }


        /*PRINCIPIO SEGREGACION DE INTERFACES
        */
        public decimal Telefono()
        {
            throw new NotImplementedException();
        }

        //public ClienteSinRegistro()
        //{
        //}

        //public string Telefono { get; set; }

    }
}
