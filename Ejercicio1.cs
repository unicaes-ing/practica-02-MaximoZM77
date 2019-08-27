using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("//////////////////////////Ejercicio1///////////////////////");
            Console.ResetColor();
            string nombre;
            Console.WriteLine("Escriba su nombre por favor");
            nombre = Console.ReadLine();
            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Su nuevo nombre es: {0}", nombre);
            Console.ReadKey();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("/////////////////////////Ejercicio2////////////////////////");
            Console.ResetColor();
            Ejercicio2.ejer2();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("/////////////////////////Ejercicio3////////////////////////");
            Console.ResetColor();
            Ejercicio3.ejer3();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("/////////////////////////Ejercicio4////////////////////////");
            Console.ResetColor();
            Ejercicio4.ejer4();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("////////////////////////Ejercicio5////////////////////////");
            Console.ResetColor();
            Ejercicio5.ejer5();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("////////////////////////Ejercicio6////////////////////////");
            Console.ResetColor();
            Ejercicio6.ejer6();
            Console.ReadKey();
            
            





        }
    }
}
