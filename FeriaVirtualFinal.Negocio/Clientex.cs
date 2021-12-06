using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Clientex
    {

        public decimal ClientexId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NomClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string RutClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PaisClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string CiudadClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string DirecClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TelefClienteX { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PostalClientex { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string CorreoClientex { get; set; }
        public decimal ClixPedidoId { get; set; }

        public Pedido Pedido { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();

        public List<Clientex> ReadClientexAll()
        {

            return this.db.CLIENTEX.Select(x => new Clientex()
            {
                ClientexId = x.CLIENTEX_ID,
                NomClientex = x.NOMBRE_EX,
                RutClientex = x.RUT_EX,
                PaisClientex = x.PAIS_EX,
                CiudadClientex = x.CIUDAD_EX,
                DirecClientex = x.DIRECCION_EX,
                TelefClienteX = x.TELEFONO_EX,
                PostalClientex = x.COD_POSTAL,
                CorreoClientex = x.CORREO_EX



            }).ToList();





        }

        public bool SaveClientex()
        {
            try
            {

                db.SP_CREATE_CLIENTEX(this.NomClientex, this.RutClientex, this.PaisClientex, this.CiudadClientex, this.DirecClientex, this.TelefClienteX, this.PostalClientex, CorreoClientex, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }

        public Clientex BuscarClientex(int ClientexId)
        {
            return this.db.CLIENTEX.Select(x => new Clientex()
            {
                ClientexId = x.CLIENTEX_ID,
                NomClientex = x.NOMBRE_EX,
                RutClientex = x.RUT_EX,
                PaisClientex = x.PAIS_EX,
                CiudadClientex = x.CIUDAD_EX,
                DirecClientex = x.DIRECCION_EX,
                TelefClienteX = x.TELEFONO_EX,
                PostalClientex = x.COD_POSTAL,
                CorreoClientex = x.CORREO_EX




            }).Where(x => x.ClientexId == ClientexId).FirstOrDefault();

        }

        public bool UpdateClientex()
        {

            try
            {
                db.SP_UPDATE_CLIENTEX(this.ClientexId,this.NomClientex, this.RutClientex, this.PaisClientex, this.CiudadClientex, this.DirecClientex, this.TelefClienteX, this.PostalClientex, CorreoClientex, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }


        }

        public bool DeleteClientex(int ClientexId)
        {
            try
            {
                db.SP_DELETE_CLIENTEX(ClientexId);
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
