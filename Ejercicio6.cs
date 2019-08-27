using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
   public class Ejercicio6
    {
        public static void ejer6()
        {
            Console.WriteLine("La fecha actual y la hora actual es la siguiente: ");
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            Console.WriteLine("Hoy es {0} {1} de {2} del {3} y son las {4}", fecha.ToString("dddd"), fecha.Day, fecha.ToString("MMM"), fecha.Year,hora.ToString("hh:mm"));
            

              
            
                    
        }
    }
}
