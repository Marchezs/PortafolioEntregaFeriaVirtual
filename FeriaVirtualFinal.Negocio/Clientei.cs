using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Clientei
    {
        public decimal ClienteiId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string RutClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string RegionClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string DirecClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ComunaClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TelefClientei { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string CorreoClientei { get; set; }
        public string CliPedidoId { get; set; }

        public Pedido pedido { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();


        public List<Clientei> ReadClienteiAll()
        {

            return this.db.CLIENTEI.Select(i => new Clientei()
            {
                ClienteiId = i.CLIENTEI_ID,
                NombClientei = i.NOMBRE_IN,
                RutClientei = i.RUT_IN,
                RegionClientei = i.REGION_IN,
                DirecClientei = i.DIRECCION_IN,
                ComunaClientei = i.COMUNA_IN,
                TelefClientei = i.TELEFONO_IN,
                CorreoClientei  = i.CORREO_IN



            }).ToList();





        }

        public bool SaveClientei()
        {
            try
            {

                db.SP_CREATE_CLIENTEI(this.NombClientei, this.RutClientei, this.RegionClientei,this.DirecClientei,this.ComunaClientei,this.TelefClientei,this.CorreoClientei, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }

        public Clientei BuscarClientei(int ClienteiId)
        {
            return this.db.CLIENTEI.Select(i => new Clientei()
            {
                ClienteiId = i.CLIENTEI_ID,
                NombClientei = i.NOMBRE_IN,
                RutClientei = i.RUT_IN,
                RegionClientei = i.REGION_IN,
                DirecClientei = i.DIRECCION_IN,
                ComunaClientei = i.COMUNA_IN,
                TelefClientei = i.TELEFONO_IN,
                CorreoClientei = i.CORREO_IN




            }).Where(i => i.ClienteiId == ClienteiId).FirstOrDefault();

        }

        public bool UpdateClientei()
        {

            try
            {
                db.SP_UPDATE_CLIENTEI(this.ClienteiId,this.NombClientei, this.RutClientei, this.RegionClientei, this.DirecClientei, this.ComunaClientei, this.TelefClientei, this.CorreoClientei, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

            
        }

        public bool DeleteClientei(int ClienteiId)
        {
            try
            {
                db.SP_DELETE_CLIENTEI(ClienteiId);
                return true;
            }
            catch
            {
                return false;
            }

        }


    }



}
