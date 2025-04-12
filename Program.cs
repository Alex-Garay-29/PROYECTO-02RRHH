using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            double pagofijoHora = 11.50;

            Console.WriteLine("Registro de Sueldo con Horas Extras");

            Console.Write("Ingrese el nombre del trabajador: ");
            string Trabajador = Console.ReadLine();

            Console.Write("Ingrese su sueldo mensual: S/ ");
            double sueldoMensual = double.Parse(Console.ReadLine());

            Console.Write("Horas Extras Trabajadas: ");
            int horasExtras = int.Parse(Console.ReadLine());

            double MontoExtra = horasExtras * pagofijoHora;
            double sueldoTotal = sueldoMensual + MontoExtra;

            Console.WriteLine(" el sueldo de {0} al mes sera de : {1} * {2} = {3} + {4} = {5}" , 
            Trabajador , horasExtras, pagofijoHora , MontoExtra , sueldoMensual , sueldoTotal );

            Console.ReadKey();
        }
    }
}
   







