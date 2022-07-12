using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroRosales
{
    internal class Cuenta 
    {
        //declaracion de variables
        Cliente cliente;
        private int saldo = 5000000;
        private int numeroCuenta;
        private int clave;
        private int puntos;
        private int retirar;

        //get and set
        public int Saldo { get => saldo; set => saldo = value; }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public int Clave1 { get => clave; set => clave = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public int Retirar1 { get => retirar; set => retirar = value; }

        //este metodo nos retrona el saldo el cual nos permite consualtarlo
        public int ConsultarSaldo()
        {            
            return Saldo;
            

        }
        //este metodo nos retorna puntos, los cuales podemos calcularlos

        public int ConsultaPuntos()
        {
            return Puntos;
        }

        // este metodo nos permite canjear puntos,
        // es importante mencionar lo siguiente por cada trasnferencia que realicemos el banco nos regala un punto ojo por cada trasnferencia entre cuentas
        //y un punto equivale a 1000 pesos " 1  punto = 1000´pesos "


        public void CanjePuntos()
        {
            if (Puntos >= 1)
            {
                Puntos = Puntos * 1000;

                Saldo = Saldo + Puntos;

                Puntos = 0;

                Console.WriteLine("un punto equivale a $1.000 pesos =) ");

                Console.WriteLine("!!!TRANSACCION EXITOSA¡¡¡ =) ");
            }
            else
            {
                Console.WriteLine("no posees puntos =(");
            }            

            
        }

        // este metodo nos permite  realizar retiros 
        public int Retirar()
        {
            int retirar = 0;
            
            Console.WriteLine("por favor ingrese el monto a retirar ");
            retirar = int.Parse(Console.ReadLine());
            
            if(retirar > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");

            }
            else if (retirar > 2000000)
            {
                Console.WriteLine("monto maximo permitio $2.000.000");
            }
            
            else if (Retirar1>=3000000)
            {
                Console.WriteLine("has alcanzado el limite de retiros permitido que equivale a 3.000.000");
            }

            else
            {
                Saldo = Saldo - retirar;
                Retirar1 = retirar + Retirar1;
                Console.WriteLine("!!!TRANSACCION EXITOSA¡¡¡ ");
            }
           
            Console.WriteLine("SU SALDO ES: ");
            return saldo;
            

        }







    }
}
