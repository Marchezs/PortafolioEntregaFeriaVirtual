using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Productor
    {
        public decimal ProductorId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductorNom { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductorRut { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductorDirec { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductorTelef { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ProductorMail { get; set; }
        public decimal ProContraId { get; set; }

        public Contrato Contrato { get; set; }

        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();

        public List<Productor> ReadProductorAll()
        {
            return this.db.PRODUCTOR.Select(l => new Productor()
            {
                ProductorId = l.PRODUCTOR_ID,
                ProductorNom = l.PRODUCTOR_NOMB,
                ProductorRut = l.PRODUCTOR_RUT,
                ProductorDirec = l.PRODUCTOR_DIREC,
                ProductorTelef = l.PRODUCTOR_TELEF,
                ProductorMail = l.PRODUCTOR_MEIL
        


            }).ToList();

        }

        public bool SaveProductor()
        {
            try
            {

                db.SP_CREATE_PRODUCTOR(this.ProductorNom, this.ProductorRut, this.ProductorDirec, this.ProductorTelef, this.ProductorMail, null);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }


        public Productor BuscarProductor(int ProductorId)
        {
            return this.db.PRODUCTOR.Select(l => new Productor()
            {
                ProductorId = l.PRODUCTOR_ID,
                ProductorNom = l.PRODUCTOR_NOMB,
                ProductorRut = l.PRODUCTOR_RUT,
                ProductorDirec = l.PRODUCTOR_DIREC,
                ProductorTelef = l.PRODUCTOR_TELEF,
                ProductorMail = l.PRODUCTOR_MEIL



            }).Where(l => l.ProductorId == ProductorId).FirstOrDefault();


        }

        public bool UpdateProductor()
        {

            try
            {
                db.SP_UPDATE_PRODUCTOR(this.ProContraId, this.ProductorNom, this.ProductorRut, this.ProductorDirec, this.ProductorTelef, this.ProductorMail,null);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public bool DeleteProductor(int ProductorId)
        {

            try
            {
                db.SP_DELETE_PRODUCTOR(ProductorId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }



    }
}
