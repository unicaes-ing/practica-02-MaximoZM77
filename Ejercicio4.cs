using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
   public class Ejercicio4
    {
        public static void ejer4()
        

        
        {
            DateTime fDI; //Fecha de iniciación
            DateTime FDD; //Fecha de devolución
            double PrecioFinal = 0, precioDia = 15;
            
            Console.WriteLine("Bienvenido a RENTACAR");
            Console.WriteLine("Ingrese la fecha de alquiler del auto");
            fDI = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolucion del auto");
            FDD = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("El precio por dia es : {0}", precioDia.ToString("C2"));
            PrecioFinal = precioDia * FDD.Subtract(fDI).Days;
            Console.WriteLine("####################################################");
            Console.WriteLine("Fecha de inicio: ");
            Console.WriteLine(fDI.ToString("dd/MM/yyyy"));
            Console.WriteLine("Fecha de devolucion: ");
            Console.WriteLine(FDD.ToString("dd/MM/yyyy"));
            Console.WriteLine(FDD.Subtract(fDI).Days + " Dias ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El total del alquiler es de : {0}",PrecioFinal.ToString("C2"));
            Console.ReadKey();
            
            

            


            
        }






    }
}
