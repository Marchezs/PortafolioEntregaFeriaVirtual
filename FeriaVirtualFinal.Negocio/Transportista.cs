using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Transportista
    {
        public decimal TransId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransNomb { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransRut { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransTelef { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransMail { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransDirec { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransMin { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransMax { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TransPatente { get; set; }
        public decimal TransSubId { get; set; }



        public Subasta Subasta { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();

        public List<Transportista> ReadTransportistaAll()
        {

            return this.db.TRANSPORTISTA.Select(t => new Transportista()
            {
                TransId = t.TRANS_ID,
                TransNomb = t.TRANS_NOMB,
                TransRut = t.TRANS_RUT,
                TransTelef = t.TRANS_TELEF,
                TransMail =   t.TRANS_MAIL,
                TransDirec =   t.TRANS_DIREC,
                TransMin =   t.TRANS_MINPESO,
                TransMax =   t.TRANS_MAXPESO,
                TransPatente =   t.TRANS_PATENTE
               



            }).ToList();





        }

        public bool SaveTransportista()
        {
            try
            {

                db.SP_CREATE_TRANSPORTISTA(this.TransNomb, this.TransRut, this.TransTelef,this.TransMail,this.TransDirec,this.TransMin,this.TransMax,this.TransPatente, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }


        public Transportista BuscarTrasportista(int TransId)
        {
            return this.db.TRANSPORTISTA.Select(t => new Transportista()
            {
                TransId = t.TRANS_ID,
                TransNomb = t.TRANS_NOMB,
                TransRut = t.TRANS_RUT,
                TransTelef = t.TRANS_TELEF,
                TransMail = t.TRANS_MAIL,
                TransDirec = t.TRANS_DIREC,
                TransMin = t.TRANS_MINPESO,
                TransMax = t.TRANS_MAXPESO,
                TransPatente = t.TRANS_PATENTE



            }).Where(t => t.TransId == TransId).FirstOrDefault();

        }


        public bool UpdateTransportista()
        {

            try
            {
                db.SP_UPDATE_TRANSPORTISTA(this.TransId,this.TransNomb, this.TransRut, this.TransTelef, this.TransMail, this.TransDirec, this.TransMin, this.TransMax, this.TransPatente, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }

        public bool DeleteTransportista(int TransId)
        {
            try
            {
                db.SP_DELETE_TRANSPORTISTA(TransId);
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
