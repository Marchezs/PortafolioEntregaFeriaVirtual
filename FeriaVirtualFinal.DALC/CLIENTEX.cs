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
    
    public partial class CLIENTEX
    {
        public decimal CLIENTEX_ID { get; set; }
        public string NOMBRE_EX { get; set; }
        public string RUT_EX { get; set; }
        public string PAIS_EX { get; set; }
        public string CIUDAD_EX { get; set; }
        public string DIRECCION_EX { get; set; }
        public string TELEFONO_EX { get; set; }
        public string COD_POSTAL { get; set; }
        public string CORREO_EX { get; set; }
        public Nullable<decimal> PEDIDO_ID { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
    }
}
