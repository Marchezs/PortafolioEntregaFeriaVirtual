using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtualFinal.DALC;

namespace FeriaVirtualFinal.Negocio
{
    public class Usuario
    {
        public decimal UsuarioId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }


        FeriaVirtualFinalEntities db = new FeriaVirtualFinalEntities();

        public bool Autenticar()
        {
            return db.USUARIO
                .Where(q => q.EMAIL == this.Email && q.PASSWORD == this.Password && q.ROL == this.Rol).FirstOrDefault() != null;
        }
        




    }






}
