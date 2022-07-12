using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroRosales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("favor ingrese su ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("favor ingrese su clave: ");
            string clave = Console.ReadLine();

            Cliente cliente1 = new Cliente("enuar", 123, "456");
            Cliente cliente2 = new Cliente("Aura Marina Salazar", 112, "789");
            cliente2.Login(id, clave);

            if (cliente2.Login(id, clave) == true)
            {
                Console.WriteLine("entraste al menu");
            }



            /*
            if (id == cliente1.Id && clave == cliente1.Clave)
            {
                Console.WriteLine("bienvenido a su banco Señor: "+ cliente1.Nombre);
            }
            else
            {
                Console.WriteLine("usuadio bloquedo");
            }*/


        }
    }
}
