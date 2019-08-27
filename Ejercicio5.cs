using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
   public class Ejercicio5
    {
        public static void ejer5()
        {
            DateTime HI; //Hora de Inicio
            DateTime HF; //Hora Final
            double PF, VXM = 0.50; //  "PF"Precio Final, "VXM" Valor por minuto 
            Console.WriteLine("Favor colocar la hora de Inicio de la llamada");
            HI = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Coloque la hora de Finalización de la llamada");
            HF = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Este es el precio por minuto de su llamada: {0}", VXM.ToString("C2"));
            PF = VXM * HF.Subtract(HI).TotalMinutes;
            Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()");
            Console.WriteLine("Hora en la que empezó la llamada fue a las : {0}", HI.ToString("HH:mm"));
            Console.WriteLine("Hora en la que terminó la llamada fue a  las : {0}", HF.ToString("HH:mm"));
            Console.WriteLine("Duración de la llamada : {0} minutos", HF.Subtract(HI).TotalMinutes);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El total a pagar es de: {0}", PF.ToString("C2"));
            Console.ReadKey();
            



        }
    }
    

    

    
    
    
}
