﻿using System;
namespace CarritoDeCompras
{
    public class CabeceraFactura
    {
        public CabeceraFactura()
        {
        }

        //Crear la clase cliente
        //public class MyProperty { get; set; }

        public ICliente ClienteCabecera { get; set; }
        public Empresa EmpresaCabecera { get; set; }


    }
}
