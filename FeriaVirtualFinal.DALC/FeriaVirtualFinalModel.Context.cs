﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class FeriaVirtualFinalEntities : DbContext
    {
        public FeriaVirtualFinalEntities()
            : base("name=FeriaVirtualFinalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CLIENTEI> CLIENTEI { get; set; }
        public DbSet<CLIENTEX> CLIENTEX { get; set; }
        public DbSet<COMPRA> COMPRA { get; set; }
        public DbSet<CONTRATO> CONTRATO { get; set; }
        public DbSet<PEDIDO> PEDIDO { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PRODUCTOR> PRODUCTOR { get; set; }
        public DbSet<SUBASTA> SUBASTA { get; set; }
        public DbSet<TRANSPORTISTA> TRANSPORTISTA { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int SP_CREATE_CLIENTEI(string v_NOMBRE, string v_RUT, string v_REGION, string v_DIRECCION, string v_COMUNA, string v_TELEFONO, string v_CORREO, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_REGIONParameter = v_REGION != null ?
                new ObjectParameter("V_REGION", v_REGION) :
                new ObjectParameter("V_REGION", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_COMUNAParameter = v_COMUNA != null ?
                new ObjectParameter("V_COMUNA", v_COMUNA) :
                new ObjectParameter("V_COMUNA", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_CORREOParameter = v_CORREO != null ?
                new ObjectParameter("V_CORREO", v_CORREO) :
                new ObjectParameter("V_CORREO", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_CLIENTEI", v_NOMBREParameter, v_RUTParameter, v_REGIONParameter, v_DIRECCIONParameter, v_COMUNAParameter, v_TELEFONOParameter, v_CORREOParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_CREATE_CLIENTEX(string v_NOMBRE, string v_RUT, string v_PAIS, string v_CIUDAD, string v_DIRECCION, string v_TELEFONO, string v_COD, string v_CORREO, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_PAISParameter = v_PAIS != null ?
                new ObjectParameter("V_PAIS", v_PAIS) :
                new ObjectParameter("V_PAIS", typeof(string));
    
            var v_CIUDADParameter = v_CIUDAD != null ?
                new ObjectParameter("V_CIUDAD", v_CIUDAD) :
                new ObjectParameter("V_CIUDAD", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_CODParameter = v_COD != null ?
                new ObjectParameter("V_COD", v_COD) :
                new ObjectParameter("V_COD", typeof(string));
    
            var v_CORREOParameter = v_CORREO != null ?
                new ObjectParameter("V_CORREO", v_CORREO) :
                new ObjectParameter("V_CORREO", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_CLIENTEX", v_NOMBREParameter, v_RUTParameter, v_PAISParameter, v_CIUDADParameter, v_DIRECCIONParameter, v_TELEFONOParameter, v_CODParameter, v_CORREOParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_CREATE_COMPRA(Nullable<decimal> v_CANTIDAD, Nullable<decimal> v_VALOR, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_CANTIDADParameter = v_CANTIDAD.HasValue ?
                new ObjectParameter("V_CANTIDAD", v_CANTIDAD) :
                new ObjectParameter("V_CANTIDAD", typeof(decimal));
    
            var v_VALORParameter = v_VALOR.HasValue ?
                new ObjectParameter("V_VALOR", v_VALOR) :
                new ObjectParameter("V_VALOR", typeof(decimal));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_COMPRA", v_CANTIDADParameter, v_VALORParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_CREATE_CONTRATO(string v_TIPO, string v_INI, string v_FIN)
        {
            var v_TIPOParameter = v_TIPO != null ?
                new ObjectParameter("V_TIPO", v_TIPO) :
                new ObjectParameter("V_TIPO", typeof(string));
    
            var v_INIParameter = v_INI != null ?
                new ObjectParameter("V_INI", v_INI) :
                new ObjectParameter("V_INI", typeof(string));
    
            var v_FINParameter = v_FIN != null ?
                new ObjectParameter("V_FIN", v_FIN) :
                new ObjectParameter("V_FIN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_CONTRATO", v_TIPOParameter, v_INIParameter, v_FINParameter);
        }
    
        public virtual int SP_CREATE_PEDIDO(string v_TIPO, string v_DATOS, string v_DESTINO, Nullable<decimal> v_PRODUCTO_ID)
        {
            var v_TIPOParameter = v_TIPO != null ?
                new ObjectParameter("V_TIPO", v_TIPO) :
                new ObjectParameter("V_TIPO", typeof(string));
    
            var v_DATOSParameter = v_DATOS != null ?
                new ObjectParameter("V_DATOS", v_DATOS) :
                new ObjectParameter("V_DATOS", typeof(string));
    
            var v_DESTINOParameter = v_DESTINO != null ?
                new ObjectParameter("V_DESTINO", v_DESTINO) :
                new ObjectParameter("V_DESTINO", typeof(string));
    
            var v_PRODUCTO_IDParameter = v_PRODUCTO_ID.HasValue ?
                new ObjectParameter("V_PRODUCTO_ID", v_PRODUCTO_ID) :
                new ObjectParameter("V_PRODUCTO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_PEDIDO", v_TIPOParameter, v_DATOSParameter, v_DESTINOParameter, v_PRODUCTO_IDParameter);
        }
    
        public virtual int SP_CREATE_PRODUCTO(string v_NOMBRE, string v_DATOS, Nullable<decimal> v_PRECIO, Nullable<decimal> v_PRODUCTOR_ID)
        {
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_DATOSParameter = v_DATOS != null ?
                new ObjectParameter("V_DATOS", v_DATOS) :
                new ObjectParameter("V_DATOS", typeof(string));
    
            var v_PRECIOParameter = v_PRECIO.HasValue ?
                new ObjectParameter("V_PRECIO", v_PRECIO) :
                new ObjectParameter("V_PRECIO", typeof(decimal));
    
            var v_PRODUCTOR_IDParameter = v_PRODUCTOR_ID.HasValue ?
                new ObjectParameter("V_PRODUCTOR_ID", v_PRODUCTOR_ID) :
                new ObjectParameter("V_PRODUCTOR_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_PRODUCTO", v_NOMBREParameter, v_DATOSParameter, v_PRECIOParameter, v_PRODUCTOR_IDParameter);
        }
    
        public virtual int SP_CREATE_PRODUCTOR(string v_NOMBRE, string v_RUT, string v_DIRECCION, string v_TELEFONO, string v_MAIL, Nullable<decimal> v_CONTRATO_ID)
        {
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_CONTRATO_IDParameter = v_CONTRATO_ID.HasValue ?
                new ObjectParameter("V_CONTRATO_ID", v_CONTRATO_ID) :
                new ObjectParameter("V_CONTRATO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_PRODUCTOR", v_NOMBREParameter, v_RUTParameter, v_DIRECCIONParameter, v_TELEFONOParameter, v_MAILParameter, v_CONTRATO_IDParameter);
        }
    
        public virtual int SP_CREATE_SUBASTA(string v_MIN, string v_MAX, string v_DESCRIP, string v_ESTADO, string v_INI, string v_FIN, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_MINParameter = v_MIN != null ?
                new ObjectParameter("V_MIN", v_MIN) :
                new ObjectParameter("V_MIN", typeof(string));
    
            var v_MAXParameter = v_MAX != null ?
                new ObjectParameter("V_MAX", v_MAX) :
                new ObjectParameter("V_MAX", typeof(string));
    
            var v_DESCRIPParameter = v_DESCRIP != null ?
                new ObjectParameter("V_DESCRIP", v_DESCRIP) :
                new ObjectParameter("V_DESCRIP", typeof(string));
    
            var v_ESTADOParameter = v_ESTADO != null ?
                new ObjectParameter("V_ESTADO", v_ESTADO) :
                new ObjectParameter("V_ESTADO", typeof(string));
    
            var v_INIParameter = v_INI != null ?
                new ObjectParameter("V_INI", v_INI) :
                new ObjectParameter("V_INI", typeof(string));
    
            var v_FINParameter = v_FIN != null ?
                new ObjectParameter("V_FIN", v_FIN) :
                new ObjectParameter("V_FIN", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_SUBASTA", v_MINParameter, v_MAXParameter, v_DESCRIPParameter, v_ESTADOParameter, v_INIParameter, v_FINParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_CREATE_TRANSPORTISTA(string v_NOMBRE, string v_RUT, string v_TELEFONO, string v_MAIL, string v_DIRECCION, string v_MIN, string v_MAX, string v_PATENTE, Nullable<decimal> v_SUB_ID)
        {
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_MINParameter = v_MIN != null ?
                new ObjectParameter("V_MIN", v_MIN) :
                new ObjectParameter("V_MIN", typeof(string));
    
            var v_MAXParameter = v_MAX != null ?
                new ObjectParameter("V_MAX", v_MAX) :
                new ObjectParameter("V_MAX", typeof(string));
    
            var v_PATENTEParameter = v_PATENTE != null ?
                new ObjectParameter("V_PATENTE", v_PATENTE) :
                new ObjectParameter("V_PATENTE", typeof(string));
    
            var v_SUB_IDParameter = v_SUB_ID.HasValue ?
                new ObjectParameter("V_SUB_ID", v_SUB_ID) :
                new ObjectParameter("V_SUB_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_TRANSPORTISTA", v_NOMBREParameter, v_RUTParameter, v_TELEFONOParameter, v_MAILParameter, v_DIRECCIONParameter, v_MINParameter, v_MAXParameter, v_PATENTEParameter, v_SUB_IDParameter);
        }
    
        public virtual int SP_CREATE_USUARIO(string v_MAIL, string v_PASSWORD, string v_ROL)
        {
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_PASSWORDParameter = v_PASSWORD != null ?
                new ObjectParameter("V_PASSWORD", v_PASSWORD) :
                new ObjectParameter("V_PASSWORD", typeof(string));
    
            var v_ROLParameter = v_ROL != null ?
                new ObjectParameter("V_ROL", v_ROL) :
                new ObjectParameter("V_ROL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_USUARIO", v_MAILParameter, v_PASSWORDParameter, v_ROLParameter);
        }
    
        public virtual int SP_DELETE_CLIENTEI(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_CLIENTEI", v_IDParameter);
        }
    
        public virtual int SP_DELETE_CLIENTEX(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_CLIENTEX", v_IDParameter);
        }
    
        public virtual int SP_DELETE__COMPRA(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE__COMPRA", v_IDParameter);
        }
    
        public virtual int SP_DELETE_CONTRATO(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_CONTRATO", v_IDParameter);
        }
    
        public virtual int SP_DELETE_PEDIDO(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_PEDIDO", v_IDParameter);
        }
    
        public virtual int SP_DELETE_PRODUCTO(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_PRODUCTO", v_IDParameter);
        }
    
        public virtual int SP_DELETE_PRODUCTOR(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_PRODUCTOR", v_IDParameter);
        }
    
        public virtual int SP_DELETE_SUBASTA(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_SUBASTA", v_IDParameter);
        }
    
        public virtual int SP_DELETE_TRANSPORTISTA(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_TRANSPORTISTA", v_IDParameter);
        }
    
        public virtual int SP_DELETE__USUARIO(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE__USUARIO", v_IDParameter);
        }
    
        public virtual int SP_UPDATE_CLIENTEI(Nullable<decimal> v_ID, string v_NOMBRE, string v_RUT, string v_REGION, string v_DIRECCION, string v_COMUNA, string v_TELEFONO, string v_CORREO, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_REGIONParameter = v_REGION != null ?
                new ObjectParameter("V_REGION", v_REGION) :
                new ObjectParameter("V_REGION", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_COMUNAParameter = v_COMUNA != null ?
                new ObjectParameter("V_COMUNA", v_COMUNA) :
                new ObjectParameter("V_COMUNA", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_CORREOParameter = v_CORREO != null ?
                new ObjectParameter("V_CORREO", v_CORREO) :
                new ObjectParameter("V_CORREO", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_CLIENTEI", v_IDParameter, v_NOMBREParameter, v_RUTParameter, v_REGIONParameter, v_DIRECCIONParameter, v_COMUNAParameter, v_TELEFONOParameter, v_CORREOParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_UPDATE_CLIENTEX(Nullable<decimal> v_ID, string v_NOMBRE, string v_RUT, string v_PAIS, string v_CIUDAD, string v_DIRECCION, string v_TELEFONO, string v_COD, string v_CORREO, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_PAISParameter = v_PAIS != null ?
                new ObjectParameter("V_PAIS", v_PAIS) :
                new ObjectParameter("V_PAIS", typeof(string));
    
            var v_CIUDADParameter = v_CIUDAD != null ?
                new ObjectParameter("V_CIUDAD", v_CIUDAD) :
                new ObjectParameter("V_CIUDAD", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_CODParameter = v_COD != null ?
                new ObjectParameter("V_COD", v_COD) :
                new ObjectParameter("V_COD", typeof(string));
    
            var v_CORREOParameter = v_CORREO != null ?
                new ObjectParameter("V_CORREO", v_CORREO) :
                new ObjectParameter("V_CORREO", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_CLIENTEX", v_IDParameter, v_NOMBREParameter, v_RUTParameter, v_PAISParameter, v_CIUDADParameter, v_DIRECCIONParameter, v_TELEFONOParameter, v_CODParameter, v_CORREOParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_UPDATE_COMPRA(Nullable<decimal> v_ID, Nullable<decimal> v_CANTIDAD, Nullable<decimal> v_VALOR, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_CANTIDADParameter = v_CANTIDAD.HasValue ?
                new ObjectParameter("V_CANTIDAD", v_CANTIDAD) :
                new ObjectParameter("V_CANTIDAD", typeof(decimal));
    
            var v_VALORParameter = v_VALOR.HasValue ?
                new ObjectParameter("V_VALOR", v_VALOR) :
                new ObjectParameter("V_VALOR", typeof(decimal));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_COMPRA", v_IDParameter, v_CANTIDADParameter, v_VALORParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_UPDATE_CONTRATO(Nullable<decimal> v_ID, string v_TIPO, string v_INI, string v_FIN)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_TIPOParameter = v_TIPO != null ?
                new ObjectParameter("V_TIPO", v_TIPO) :
                new ObjectParameter("V_TIPO", typeof(string));
    
            var v_INIParameter = v_INI != null ?
                new ObjectParameter("V_INI", v_INI) :
                new ObjectParameter("V_INI", typeof(string));
    
            var v_FINParameter = v_FIN != null ?
                new ObjectParameter("V_FIN", v_FIN) :
                new ObjectParameter("V_FIN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_CONTRATO", v_IDParameter, v_TIPOParameter, v_INIParameter, v_FINParameter);
        }
    
        public virtual int SP_UPDATE_PEDIDO(Nullable<decimal> v_ID, string v_TIPO, string v_DATOS, string v_DESTINO, Nullable<decimal> v_PRODUCTO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_TIPOParameter = v_TIPO != null ?
                new ObjectParameter("V_TIPO", v_TIPO) :
                new ObjectParameter("V_TIPO", typeof(string));
    
            var v_DATOSParameter = v_DATOS != null ?
                new ObjectParameter("V_DATOS", v_DATOS) :
                new ObjectParameter("V_DATOS", typeof(string));
    
            var v_DESTINOParameter = v_DESTINO != null ?
                new ObjectParameter("V_DESTINO", v_DESTINO) :
                new ObjectParameter("V_DESTINO", typeof(string));
    
            var v_PRODUCTO_IDParameter = v_PRODUCTO_ID.HasValue ?
                new ObjectParameter("V_PRODUCTO_ID", v_PRODUCTO_ID) :
                new ObjectParameter("V_PRODUCTO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_PEDIDO", v_IDParameter, v_TIPOParameter, v_DATOSParameter, v_DESTINOParameter, v_PRODUCTO_IDParameter);
        }
    
        public virtual int SP_UPDATE_PRODUCTO(Nullable<decimal> v_ID, string v_NOMBRE, string v_DATOS, Nullable<decimal> v_PRECIO, Nullable<decimal> v_PRODUCTOR_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_DATOSParameter = v_DATOS != null ?
                new ObjectParameter("V_DATOS", v_DATOS) :
                new ObjectParameter("V_DATOS", typeof(string));
    
            var v_PRECIOParameter = v_PRECIO.HasValue ?
                new ObjectParameter("V_PRECIO", v_PRECIO) :
                new ObjectParameter("V_PRECIO", typeof(decimal));
    
            var v_PRODUCTOR_IDParameter = v_PRODUCTOR_ID.HasValue ?
                new ObjectParameter("V_PRODUCTOR_ID", v_PRODUCTOR_ID) :
                new ObjectParameter("V_PRODUCTOR_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_PRODUCTO", v_IDParameter, v_NOMBREParameter, v_DATOSParameter, v_PRECIOParameter, v_PRODUCTOR_IDParameter);
        }
    
        public virtual int SP_UPDATE_PRODUCTOR(Nullable<decimal> v_ID, string v_NOMBRE, string v_RUT, string v_DIRECCION, string v_TELEFONO, string v_MAIL, Nullable<decimal> v_CONTRATO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_CONTRATO_IDParameter = v_CONTRATO_ID.HasValue ?
                new ObjectParameter("V_CONTRATO_ID", v_CONTRATO_ID) :
                new ObjectParameter("V_CONTRATO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_PRODUCTOR", v_IDParameter, v_NOMBREParameter, v_RUTParameter, v_DIRECCIONParameter, v_TELEFONOParameter, v_MAILParameter, v_CONTRATO_IDParameter);
        }
    
        public virtual int SP_UPDATE_SUBASTA(Nullable<decimal> v_ID, string v_MIN, string v_MAX, string v_DESCRIP, string v_ESTADO, string v_INI, string v_FIN, Nullable<decimal> v_PEDIDO_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_MINParameter = v_MIN != null ?
                new ObjectParameter("V_MIN", v_MIN) :
                new ObjectParameter("V_MIN", typeof(string));
    
            var v_MAXParameter = v_MAX != null ?
                new ObjectParameter("V_MAX", v_MAX) :
                new ObjectParameter("V_MAX", typeof(string));
    
            var v_DESCRIPParameter = v_DESCRIP != null ?
                new ObjectParameter("V_DESCRIP", v_DESCRIP) :
                new ObjectParameter("V_DESCRIP", typeof(string));
    
            var v_ESTADOParameter = v_ESTADO != null ?
                new ObjectParameter("V_ESTADO", v_ESTADO) :
                new ObjectParameter("V_ESTADO", typeof(string));
    
            var v_INIParameter = v_INI != null ?
                new ObjectParameter("V_INI", v_INI) :
                new ObjectParameter("V_INI", typeof(string));
    
            var v_FINParameter = v_FIN != null ?
                new ObjectParameter("V_FIN", v_FIN) :
                new ObjectParameter("V_FIN", typeof(string));
    
            var v_PEDIDO_IDParameter = v_PEDIDO_ID.HasValue ?
                new ObjectParameter("V_PEDIDO_ID", v_PEDIDO_ID) :
                new ObjectParameter("V_PEDIDO_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_SUBASTA", v_IDParameter, v_MINParameter, v_MAXParameter, v_DESCRIPParameter, v_ESTADOParameter, v_INIParameter, v_FINParameter, v_PEDIDO_IDParameter);
        }
    
        public virtual int SP_UPDATE_TRANSPORTISTA(Nullable<decimal> v_ID, string v_NOMBRE, string v_RUT, string v_TELEFONO, string v_MAIL, string v_DIRECCION, string v_MIN, string v_MAX, string v_PATENTE, Nullable<decimal> v_SUB_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_NOMBREParameter = v_NOMBRE != null ?
                new ObjectParameter("V_NOMBRE", v_NOMBRE) :
                new ObjectParameter("V_NOMBRE", typeof(string));
    
            var v_RUTParameter = v_RUT != null ?
                new ObjectParameter("V_RUT", v_RUT) :
                new ObjectParameter("V_RUT", typeof(string));
    
            var v_TELEFONOParameter = v_TELEFONO != null ?
                new ObjectParameter("V_TELEFONO", v_TELEFONO) :
                new ObjectParameter("V_TELEFONO", typeof(string));
    
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_DIRECCIONParameter = v_DIRECCION != null ?
                new ObjectParameter("V_DIRECCION", v_DIRECCION) :
                new ObjectParameter("V_DIRECCION", typeof(string));
    
            var v_MINParameter = v_MIN != null ?
                new ObjectParameter("V_MIN", v_MIN) :
                new ObjectParameter("V_MIN", typeof(string));
    
            var v_MAXParameter = v_MAX != null ?
                new ObjectParameter("V_MAX", v_MAX) :
                new ObjectParameter("V_MAX", typeof(string));
    
            var v_PATENTEParameter = v_PATENTE != null ?
                new ObjectParameter("V_PATENTE", v_PATENTE) :
                new ObjectParameter("V_PATENTE", typeof(string));
    
            var v_SUB_IDParameter = v_SUB_ID.HasValue ?
                new ObjectParameter("V_SUB_ID", v_SUB_ID) :
                new ObjectParameter("V_SUB_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_TRANSPORTISTA", v_IDParameter, v_NOMBREParameter, v_RUTParameter, v_TELEFONOParameter, v_MAILParameter, v_DIRECCIONParameter, v_MINParameter, v_MAXParameter, v_PATENTEParameter, v_SUB_IDParameter);
        }
    
        public virtual int SP_UPDATE_USUARIO(Nullable<decimal> v_ID, string v_MAIL, string v_PASSWORD, string v_ROL)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            var v_MAILParameter = v_MAIL != null ?
                new ObjectParameter("V_MAIL", v_MAIL) :
                new ObjectParameter("V_MAIL", typeof(string));
    
            var v_PASSWORDParameter = v_PASSWORD != null ?
                new ObjectParameter("V_PASSWORD", v_PASSWORD) :
                new ObjectParameter("V_PASSWORD", typeof(string));
    
            var v_ROLParameter = v_ROL != null ?
                new ObjectParameter("V_ROL", v_ROL) :
                new ObjectParameter("V_ROL", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_USUARIO", v_IDParameter, v_MAILParameter, v_PASSWORDParameter, v_ROLParameter);
        }
    }
}