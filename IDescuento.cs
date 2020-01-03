using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    /*PRINCIPIO SUSTITUCION DE LISKOV
     * EL DESCUENTO VARIA SEGUN EL CASO DEL CLIENTE
        */
    interface IDescuento
    {
        decimal Descuento();
    }
}
