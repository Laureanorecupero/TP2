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

        public static UsuarioLogic UsuarioNegocio { get; set; } = new UsuarioLogic();



        public void Menu()
        {
            int rta;
            do
            {
                Console.WriteLine("Ingrese la opcion que corresponda \n 1- Listado General \n 2- Consulta \n 3- Agregar \n 4- Modificar \n 5- Eliminar \n 6-Salir");
                rta = Convert.ToInt32(Console.ReadLine());
                switch (rta)
                {
                    case 1:

                        ListadoGeneral();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Eliminar();
                        break;



                }


            } while (rta != 6);



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
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\t Nombre: {0}", usr.Nombre);
            Console.WriteLine("\t\t Apellido:{0}", usr.Apellido);
            Console.WriteLine("\t\t Nombre de Usuario:{0}", usr.NombreUsuario);
            Console.WriteLine("\t\t Clave:{0}", usr.Clave);
            Console.WriteLine("\t\t Email:{0}", usr.Email);
            Console.WriteLine("\t\t Habilitado:{0}", usr.Habilitado);
            Console.WriteLine();






        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a Consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();

            }


        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a modificar");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre Usuario");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese habilitacion de usuario (1-SI otro-NO)");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();

            }
        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            Console.Write("Ingrese el nombre");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre usuario");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese clave");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese habilitacion de usuario (1-SI otro-NO)");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);

        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();

            }
        }

     }
    

}
