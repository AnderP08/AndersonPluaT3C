using System;
namespace CarritoDeCompras
{
    public class ClienteRegistrado : ICliente, IDescuento
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



        //public ClienteRegistrado()
        //{

        //}

        //public DateTime FechaInicioRegistro { get; set; }
        //public DateTime FechaFinRegistro { get; set; }

        //public decimal FechaRegistro()
        //{
        //    TimeSpan timeSpan = DateTime.Today - this.FechaInicioRegistro;
        //    int dias = timeSpan.Days;
        //    int fecha = dias / 365;
        //    return fecha;
        //}
        //public decimal FechaFin()
        //{
        //    TimeSpan timeSpan = DateTime.Today - this.FechaFinRegistro;
        //    int dias = timeSpan.Days;
        //    int fecha = dias / 365;
        //    return fecha;
        //}


    }
}
