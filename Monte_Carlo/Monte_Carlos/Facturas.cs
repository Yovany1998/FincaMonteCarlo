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
    
    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            this.DetalleVenta = new HashSet<DetalleVenta>();
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int IdFactura { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Impuesto { get; set; }
        public Nullable<double> Total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
