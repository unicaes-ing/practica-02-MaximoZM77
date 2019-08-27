using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Proyecto_2
{
   public class Ejercicio2
    {
        public static void ejer2() 
        {
            double Leche = 2.50, Queso = 1.00, Pan = 0.50,  IVA = 0.13, total_a_pagar = 0, producto = 0, cantidad = 0, subtotal = 0;
            
            Console.Write("Buenas Tardes, que producto desea?");
            Console.ReadLine();
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.ReadKey();
            Console.WriteLine("1.Leche");
            Console.WriteLine("2.Queso");
            Console.WriteLine("3.Pan");
            producto = Convert.ToInt32(Console.ReadLine());
            switch (producto)
            {
                case 1:
                    Console.WriteLine("Ha escogido leche");
                    Console.WriteLine("Cuantas cantidades de este producto desea?");
                    cantidad = Convert.ToDouble(Console.ReadLine());
                    subtotal = cantidad * Leche;
                    Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                    Console.ReadKey();
                    Console.WriteLine("El producto tiene un IVA del 13%");
                    IVA = subtotal * IVA;
                    subtotal = subtotal + IVA;
                    Console.WriteLine("Su IVA seria de: " + IVA.ToString("C2"));
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Su total a pagar es de : " + subtotal.ToString("C2"));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Ha escogido el queso");
                    Console.WriteLine("Cuantas cantidades de este producto desea?");
                    cantidad = Convert.ToDouble(Console.ReadLine());
                    subtotal = cantidad * Queso;
                    Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                    Console.ReadKey();
                    Console.WriteLine("El producto tiene un IVA del 13%");
                    IVA = subtotal * IVA;
                    subtotal = subtotal + IVA;
                    Console.WriteLine("Su IVA seria de: " + IVA.ToString("C2"));
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Su total a pagar es de : " + subtotal.ToString("C2"));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Ha escogido Pan");
                    Console.WriteLine("Cuantas cantidades de este producto desea?");
                    cantidad = Convert.ToDouble(Console.ReadLine());
                    subtotal = cantidad * Pan;
                    Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                    Console.ReadKey();
                    Console.WriteLine("El producto tiene un IVA del 13%");
                    IVA = subtotal * IVA;
                    subtotal = subtotal + IVA;
                    Console.WriteLine("Su IVA seria de: " + IVA.ToString("C2"));
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Su total a pagar es de : " + subtotal.ToString("C2"));
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            
        }







    }
}
