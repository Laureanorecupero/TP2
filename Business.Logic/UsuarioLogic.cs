using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;





namespace Business.Logic
{
    public class UsuarioLogic : BussinesLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }
        
        public List<Usuario> GetAll()
        {
           return UsuarioData.GetAll();
        }

       public Usuario GetOne(int ID)
        {
           return UsuarioData.GetOne(ID);
        }

        public void Delete (int ID)
        {
             UsuarioData.Delete(ID);
        }

        public void Save(Usuario user)
        {
             UsuarioData.Save(user);
        }





    }
}
