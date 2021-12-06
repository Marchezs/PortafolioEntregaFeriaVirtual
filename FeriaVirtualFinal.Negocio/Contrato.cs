using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Contrato
    {
        public decimal ContratoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ContratoTipo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ContratoIni { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ContratoFin { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();


        public List<Contrato> ReadContrato()
        {

            return db.CONTRATO.Select(u => new Contrato()
            {

                ContratoId = u.CONTRATO_ID,
                ContratoTipo = u.CONTRATO_TIPO,
                ContratoIni = u.CONTRATO_INI,
                ContratoFin = u.CONTRATO_FIN






            }).ToList();




        }

        public bool SaveContrato()
        {
            try
            {

                db.SP_CREATE_CONTRATO(this.ContratoTipo, this.ContratoIni, this.ContratoFin);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }


        public Contrato BuscarContrato(int ContratoId)
        {
            return this.db.CONTRATO.Select(u => new Contrato()
            {
                ContratoId = u.CONTRATO_ID,
                ContratoTipo = u.CONTRATO_TIPO,
                ContratoIni = u.CONTRATO_INI,
                ContratoFin = u.CONTRATO_FIN




            }).Where(u => u.ContratoId == ContratoId).FirstOrDefault();

        }

        public bool UpdateContrato()
        {

            try
            {
                db.SP_UPDATE_CONTRATO(this.ContratoId,this.ContratoTipo, this.ContratoIni, this.ContratoFin);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }

        public bool DeleteContrato(int ContratoId)
        {
            try
            {
                db.SP_DELETE_CONTRATO(ContratoId);
                return true;
            }
            catch
            {
                return false;
            }

        }





    }
}
