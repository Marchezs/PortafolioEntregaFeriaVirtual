using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Subasta
    {
        public decimal SubastaId { get; set; }
        [Required, MinLength(4,ErrorMessage = "No cumple con los requesitos de peso"), MaxLength(4, ErrorMessage = "No cumple con los requesitos de peso")]
        public string SubPesoMin { get; set; }
        [Required,MinLength(5,ErrorMessage = "No cumple con los requesitos de peso"),MaxLength(6,ErrorMessage = "No cumple con los requesitos de peso ")] 
        public string SubPesoMax { get; set; }
        public string SubDecrip { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string SubEstado { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string SubIni { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string SubFin { get; set; }
        public decimal SubPedidoId { get; set; }

        public Pedido pedido { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();


        public List<Subasta> ReadSubastaAll()
        {

            return this.db.SUBASTA.Select(s => new Subasta()
            {
                SubastaId = s.SUB_ID,
                SubPesoMin = s.SUB_MINPESO,
                SubPesoMax = s.SUB_MAXPESO,
                SubDecrip = s.SUB_DESCRIP,
                SubEstado =s.SUB_ESTADO,
                SubIni =s.SUB_INI,
                SubFin = s.SUB_FIN

            }).ToList();





        }


        public bool SaveSubasta()
        {
            try
            {

                db.SP_CREATE_SUBASTA(this.SubPesoMin, this.SubPesoMax, SubDecrip, SubEstado, SubIni, SubFin, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }


        public Subasta BuscarSubasta(int SubastaId)
        {
            return this.db.SUBASTA.Select(s => new Subasta()
            {
                SubastaId = s.SUB_ID,
                SubPesoMin = s.SUB_MINPESO,
                SubPesoMax = s.SUB_MAXPESO,
                SubDecrip = s.SUB_DESCRIP,
                SubEstado = s.SUB_ESTADO,
                SubIni = s.SUB_INI,
                SubFin = s.SUB_FIN




            }).Where(s => s.SubastaId == SubastaId).FirstOrDefault();

        }

        public bool UpdateSubasta()
        {

            try
            {
                db.SP_UPDATE_SUBASTA(this.SubastaId,this.SubPesoMin, this.SubPesoMax, SubDecrip, SubEstado, SubIni, SubFin, null);
                return true;

            }


            catch (Exception)
            {
                return false;

            }

        }

        public bool DeleteSubasta(int SubastaId)
        {
            try
            {
                db.SP_DELETE_SUBASTA(SubastaId);
                return true;
            }
            catch
            {
                return false;
            }

        }


    }
}
