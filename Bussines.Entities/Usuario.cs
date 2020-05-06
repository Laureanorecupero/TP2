using Bussines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Bussines.Entities
{
    public class Usuario:BusinessEntity
    {
        private string _User;
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        private string _password;
        public string password 
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}
