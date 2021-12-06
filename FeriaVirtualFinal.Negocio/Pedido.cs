using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Pedido
    {

        public decimal PedidoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PedidoTipo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PedidoDatos { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PedidoDestino { get; set; }
        public decimal PediProducId { get; set; }




        public Producto producto { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();

        public List<Pedido> ReadPedidoAll()
        {

            return this.db.PEDIDO.Select(o => new Pedido()
            {
                PedidoId = o.PEDIDO_ID,
                PedidoTipo = o.PEDIDO_TIPO,
                PedidoDatos = o.PEDIDO_DATOS,
                PedidoDestino = o.PEDIDO_DESTINO




            }).ToList();





        }

        public bool SavePedido()
        {
            try
            {

                db.SP_CREATE_PEDIDO(this.PedidoTipo, this.PedidoDatos, this.PedidoDestino, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }

        public Pedido BuscarPedido(int PedidoId)
        {
            return this.db.PEDIDO.Select(o => new Pedido()
            {
                PedidoId = o.PEDIDO_ID,
                PedidoTipo = o.PEDIDO_TIPO,
                PedidoDatos = o.PEDIDO_DATOS,
                PedidoDestino = o.PEDIDO_DESTINO




            }).Where(o => o.PedidoId == PedidoId).FirstOrDefault();

        }


        public bool UpdatePedido()
        {

            try
            {
                db.SP_UPDATE_PEDIDO(this.PedidoId, this.PedidoTipo, this.PedidoDatos, this.PedidoDestino, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }


        public bool DeletePedido(int PedidoId)
        {
            try
            {
                db.SP_DELETE_PEDIDO(PedidoId);
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
