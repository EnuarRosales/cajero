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
            Console.WriteLine("xxxxxxxxxxxxxxxxxxx UNIVERSIDAD NACIONAL ABIERTA Y A DISTANCIA xxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx JOSE ACEVEDO Y GOMEZ xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx BANCO DE COLOMBIA UNAD xxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx usuraio id = 112 clave 789 xxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx cuenta para trasnferir 123456 xxxxxxxxxxxxxxxxxxxxxxxxx");


            //usuarios creados

            Cliente cliente3 = new Cliente("Aura Marina Salazar",112,"789",123457);
                                                           

            Console.WriteLine("\n");
            // cliente2.Login(id, clave);        
            string control = " ";
            int id = 0;
            string clave = " ";


            try
            {
                Console.WriteLine("favor ingrese su ID: ");
                 id = int.Parse(Console.ReadLine());
                Console.WriteLine("favor ingrese su clave: ");
                clave = Console.ReadLine();
                
            }

            catch(Exception ex)
            {
                Console.WriteLine("solo de admiten valores numericos");
            }
            

            do
            {
                int selec= 0;     
                


                if (cliente3.Login(id, clave) == true)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("por favor seleccione la operacion a relizar \n" +
                            "1. Consulta de saldo \n" +
                            "2. Retiros\n" +
                            "3. Transferencias\n" +
                            "4. Consulta de puntos vive Colombia\n" +
                            "5. Canje de puntos vive Colombia");
                try
                    {
                      selec = int.Parse(Console.ReadLine());
                    }
                 catch (Exception ex)
                    {
                       Console.WriteLine("solo de admiten valores numericos");
                    }
                    
                }

                if (selec == 1)
                {
                    Console.WriteLine("su saldo es: ");
                    Console.WriteLine(cliente3.ConsultarSaldo());


                }

                else if (selec == 2)
                {
                    
                    Console.WriteLine(cliente3.Retirar());


                }

                else if (selec == 3)
                {
                    cliente3.trasnferir(cliente3.Cuent);                


                }

                else if (selec == 4)
                {
                    Console.WriteLine("sus puntos acumulados son : ");
                    Console.WriteLine(cliente3.ConsultaPuntos());
                    Console.WriteLine("Recuerde que por cada transaccion que realices el banco te da un punto Vivecolombia ");


                }

                else if (selec == 5)
                {
                    
                    cliente3.CanjePuntos();                   

                }

                else if (selec >= 6)
                {
                    Console.WriteLine("numero incorrecto");
                }


                else
                {
                    if (cliente3.Login(id, clave) == false)
                    {
                        control = " ";

                        try
                        {
                            Console.WriteLine("estas ingresando de manera erronea los datos: ");
                            Console.WriteLine("favor ingrese su ID: ");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine("favor ingrese su clave: ");
                            clave = Console.ReadLine();
                            Console.WriteLine("el sistema esta volviendo a verificar tus datos: ");
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("solo de admiten valores numericos");
                            
                            
                        }

                    }
                } 
            
                Console.WriteLine("presione cualquier tecla para continuar =) ");                
                Console.ReadLine();
                Console.Clear();                              
                                        
                               
                
            }
            
            while (control != "n");


                        

        }
    }
}
