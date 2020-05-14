using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            new Usuarios().Menu();

        }

        
    }
}
