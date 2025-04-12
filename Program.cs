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

            double MontoExtra;
            double sueldoFinal;

            if (horasExtras > 0)
            {
                MontoExtra = horasExtras * pagofijoHora;
                sueldoFinal = sueldoMensual + MontoExtra;
            }
            else
            {
                sueldoFinal = sueldoMensual;
            }
            Console.WriteLine("El sueldo total al mes de " + Trabajador + " será: S/ " + sueldoFinal.ToString("F2"));

            Console.ReadKey();
        }
    }
}







