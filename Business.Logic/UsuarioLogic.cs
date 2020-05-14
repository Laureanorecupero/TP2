using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Entities;
using Data.Database;





namespace Business.Logic
{
    public class UsuarioLogic : BussinesLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }
        public List<Usuario> GetAll()
        {
           return UsuarioAdapter.GetAll();
        }

       public Usuario GetOne(int ID)
        {
           return UsuarioAdapter.GetOne(ID);
        }

        public void Delete (int ID)
        {
            UsuarioAdapter.Delete(ID);
        }

        public void Save(Usuario user)
        {
            UsuarioAdapter.Save(user);
        }





    }
}
