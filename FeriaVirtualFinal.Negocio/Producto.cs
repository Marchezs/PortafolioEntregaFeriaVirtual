using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Producto
    {
        public decimal ProductoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductoNomb { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductoDatos { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal ProductoPrecio { get; set; }
        public decimal ProduProtorId { get; set; }

        public Productor Productor { get; set; }


        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();


        public List<Producto> ReadProductoAll()
        {

            return this.db.PRODUCTO.Select(p => new Producto()
            {
                ProductoId = p.PRODUCTO_ID,
                ProductoNomb = p.PRODUCTO_NOMB,
                ProductoDatos = p.PRODUCTO_DATOS,
                ProductoPrecio = (decimal)p.PRODUCTO_PRECIO




            }).ToList();





        }

        public bool SaveProducto()
        {
            try
            {

                db.SP_CREATE_PRODUCTO(this.ProductoNomb, this.ProductoDatos, this.ProductoPrecio, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }


        public Producto BuscarProducto(int ProductoId)
        {
            return this.db.PRODUCTO.Select(p => new Producto()
            {
                ProductoId = p.PRODUCTO_ID,
                ProductoNomb = p.PRODUCTO_NOMB,
                ProductoDatos = p.PRODUCTO_DATOS,
                ProductoPrecio = (decimal)p.PRODUCTO_PRECIO




            }).Where(p => p.ProductoId == ProductoId).FirstOrDefault();

        }

        public bool UpdateProducto()
        {

            try
            {
                db.SP_UPDATE_PRODUCTO(this.ProductoId, this.ProductoNomb, this.ProductoDatos, this.ProductoPrecio, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }

        public bool DeleteProducto(int ProductoId)
        {
            try
            {
                db.SP_DELETE_PRODUCTO(ProductoId);
                return true;
            }
            catch
            {
                return false;
            }
           
        }




    }
 
}
