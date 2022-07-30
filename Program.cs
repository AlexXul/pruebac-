using System;
using Ejemplo.Modelos;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           /*  Usuario _Usuario;
            _Usuario = new Usuario();
            _Usuario.Nombre = "Alex";
            _Usuario.Edad = 22;
           
            //error pos ser privado
           // _Usuario.Correo ="alex@gmail.com";
            _Usuario.SetCorreo("alex@gmail.com");
            _Usuario.Apellido="xul";
            _Usuario.Contrasenia="holamundo";
             Console.WriteLine(_Usuario.Info());
             Console.WriteLine("ingrese su nombre"); */

             /* string Nombre=Console.ReadLine();
             Console.WriteLine("ingrese su edad");
             int Edad = int.Parse(Console.ReadLine());
            
            Usuario _Usuario1=new Usuario(Nombre,"XUL",Edad,"ALEX@gmial.com","holammundo");
            
            Console.WriteLine(_Usuario1.Info()); */
            Telefono[]Telefonos=new Telefono[]{
                new Telefono{CodigoPais= 12,Numero= "9992658918"},
                new Telefono{CodigoPais= 52,Numero= "9999999999"},
                new Telefono{CodigoPais= 12,Numero= "8888888888"}
            };

            foreach (Telefono item in Telefonos){
                //Console.WriteLine(item.Info());
            }

            Usuario[]Usuarios=new Usuario[]{
                new Usuario("Alex","XUL",21,"ALEX@gmial.com","holammundo",Telefonos[0]),
                new Usuario("Alvaro","Canche",22,"ALEX@gmial.com","holammundo",Telefonos[1]),
                new Usuario("Ezequiel","ku",22,"ALEX@gmial.com","holammundo",Telefonos[2]),
            };
            foreach(Usuario elem in Usuarios){
                Console.WriteLine(elem.Info());
                Console.WriteLine(elem.Telefono.Info());
            }


        }
    }
}
