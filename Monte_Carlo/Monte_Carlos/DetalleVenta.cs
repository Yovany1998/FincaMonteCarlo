//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monte_Carlos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVenta
    {
        public int IdDetalleVentas { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int IdVenta { get; set; }
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdComidaBebida { get; set; }
        public Nullable<double> PrecioComidaBebida { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Impuesto { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
