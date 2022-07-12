using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroRosales
{
    internal class Cliente
    {
        //declaracion de las variables
        private string nombre;
        private int id;
        private string clave;
        
        //metodo construcor
        public Cliente(string nombre, int id, string clave)
        {
            this.nombre = nombre;
            this.id = id;
            this.clave = clave;
        }

        //declaracion de los get and set 

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Clave { get => clave; set => clave = value; }


        //metodo para la autenticacion de los usuarios
        public bool Login(int I, string C)
        {
            if (id == I)
            {
                if (clave == C)
                { Console.WriteLine("bienvenido a su banco Señor: " + Nombre); 
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
