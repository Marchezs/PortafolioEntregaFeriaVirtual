//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeriaVirtualFinal.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPRA
    {
        public decimal COMPRA_ID { get; set; }
        public Nullable<decimal> COMPRA_CANT { get; set; }
        public Nullable<decimal> COMPRA_VALOR { get; set; }
        public Nullable<decimal> PEDIDO_ID { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
    }
}