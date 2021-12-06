using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Compra
    {

        public decimal CompraId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal CantidadCompra { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal ValorCompra { get; set; }
        public decimal ComPedidoId { get; set; }


        public Pedido pedido { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();


        public List<Compra> ReadCompraAll()
        {

            return this.db.COMPRA.Select(r => new Compra()
            {
                CompraId = r.COMPRA_ID,
                CantidadCompra = (decimal)r.COMPRA_CANT,
                ValorCompra = (decimal)r.COMPRA_VALOR
                



            }).ToList();





        }

        public bool SaveCompra()
        {
            try
            {

                db.SP_CREATE_COMPRA(this.CantidadCompra, this.ValorCompra, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }

        public Compra BuscarCompra(int CompraId)
        {
            return this.db.COMPRA.Select(r => new Compra()
            {
                CompraId = r.COMPRA_ID,
                CantidadCompra = (decimal)r.COMPRA_CANT,
                ValorCompra = (decimal)r.COMPRA_VALOR





            }).Where(r => r.CompraId == CompraId).FirstOrDefault();

        }


        public bool UpdateCompra()
        {

            try
            {
                db.SP_UPDATE_COMPRA(this.CompraId, this.CantidadCompra, this.ValorCompra, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }

        public bool DeleteCompra(int CompraId)
        {
            try
            {
                db.SP_DELETE__COMPRA(CompraId);
                return true;
            }
            catch
            {
                return false;
            }

        }





    }








}
