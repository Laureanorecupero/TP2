using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace Ui.Consola
{
    public class Usuarios
    {

        public static UsuarioLogic UsuarioNegocio { get; set; }


        public void Menu()
        {
            int rta;
            do
            {
                Console.WriteLine("Ingrese la opcion que corresponda \n 1- Listado General \n 2- Consulta \n 3- Agregar \n 4- Modificar \n 5- Salir");
                rta = Convert.ToInt32(Console.ReadKey());
                switch (rta)
                {
                    case 1:
                        
                        ListadoGeneral();
                        break;
                    

                }


            } while (rta != 5);



        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }
        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: ´{0}", usr.ID);
            Console.WriteLine("\t\t Nombre: {0}", usr.Nombre);
            Console.WriteLine("\t\t Apellido:{0}", usr.Apellido);
            Console.WriteLine("\t\t Nombre de Usuario:{0}", usr.NombreUsuario);
            Console.WriteLine("\t\t Clave:{0}", usr.Clave);
            Console.WriteLine("\t\t Email:{0}", usr.Email);
            Console.WriteLine("\t\t Habilitado:{0}", usr.Habilitado);
            Console.WriteLine();






        }


















    }
    

}
