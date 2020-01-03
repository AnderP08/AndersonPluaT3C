using System;
namespace CarritoDeCompras
{
    public class ClientePremium : ICliente, IDescuento
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

        //public ClientePremium()
        //{
        //    this.Descuento = 0.10M;
        //}

        //public DateTime FechaInscri { get; set; }
        //public decimal Descuento { get; set; }

        //public decimal FechaDeInscre()
        //{
        //    TimeSpan timeSpan = DateTime.Today - this.FechaInscri;
        //    int dias = timeSpan.Days;
        //    int fecha = dias / 365;
        //    return fecha;
        //}

    }
}
