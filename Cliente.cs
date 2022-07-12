using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroRosales
{
    internal class Cliente : Cuenta
    {
        //declaracion de las variables
        private string nombre;
        private int id;
        private string clave;
        private int cuent;
        
        
        //metodo construcor
        public Cliente(string nombre, int id, string clave, int cuent)
        {
            this.nombre = nombre;
            this.id = id;
            this.clave = clave;
            this.cuent = cuent;
        }

        public Cliente()
        {
            Nombre = clave;
            Id = id;
            Clave = clave;
            Cuent = Cuent;
        }
     

        //declaracion de los get and set 

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Cuent { get => cuent; set => cuent = value; }


        //metodo para la autenticacion de los usuarios
        public bool Login(int I, string C)
        {
            
            if (id == I)
            {
                if (clave == C)
                { Console.WriteLine("bienvenido a su banco Señora: " + Nombre);
                    return true;
                }
                else
                {
                    
                 Console.WriteLine("contraseña Incorrecta");
                    
                }
            }
            else
            {
                Console.WriteLine("ID Incorrecto");
            }
            return false;
        }


        // nos permite simular persistencia de datos
        public bool trasnferir(int I)
        {
            //persistencia de datos 
            Cliente cliente1 = new Cliente("enuar emilio rosales", 123, "456", 123456);

            Console.WriteLine("favor ingrese la cuenta a la cual desea realiar la transaccion: ");
             I = int.Parse(Console.ReadLine());
             

            if (cliente1.Cuent == I)
            {
                int descontar = 0;
                Console.WriteLine("la cuenta se encuentra registrada en el sistema");
                Console.WriteLine("por favor ingrese el monto a trasnferir: ");
                descontar = int.Parse(Console.ReadLine());

                if (descontar <= Saldo)
                {
                    Saldo = Saldo - descontar;

                    Console.WriteLine("!!!TRANSACCION EXITOSA¡¡¡:");
                    Console.WriteLine("el dinero fue trasnferdo al señor:" + cliente1.Nombre);

                    Puntos++;
                    Console.WriteLine("sus puntos por utilizar nuestros servicios son: " + Puntos);// un punto equivale a 1000 pesos
                    return true;
                }
                else
                {
                    Console.WriteLine("saldo insuficionte");
                }
                               
                
            }

            else
            {

                Console.WriteLine("cuenta herrada");
            }
            return false;


        }   

              








        //el mismo metodo sin validar crdenciales

        /*public void Login(int I, string C)
        {
            if (id == I && clave == C)
            {
                Console.WriteLine("bienvenido a su banco Señor: " + Nombre);
            }
            else
            {
                Console.WriteLine("contraseña Incorrecta");
            }              


        }*/
    }
}
