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
    
    public partial class CLIENTEI
    {
        public decimal CLIENTEI_ID { get; set; }
        public string NOMBRE_IN { get; set; }
        public string RUT_IN { get; set; }
        public string REGION_IN { get; set; }
        public string DIRECCION_IN { get; set; }
        public string COMUNA_IN { get; set; }
        public string TELEFONO_IN { get; set; }
        public string CORREO_IN { get; set; }
        public Nullable<decimal> PEDIDO_ID { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
    }
}