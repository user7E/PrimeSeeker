/*  Pequeno programa para achar e verificar números primos.
 *  inspirado no Algoritmo de Eratóstenes(também conhecido como Crivo de Eratóstenees)
 *  para encontrá-los aritmeticamente.
 *
 *  Written by Caio Cezar, 2023
 *      PrimeSeeker
 *       v0.1a
 *       GPL2
 *      
*/

using System;

namespace PrimesCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var
            double num0, num1, num2;
            string cnum0, cnum1, cnum2;

            CPA cpa1 = new CPA();
            Console.WriteLine("Iniciando...");
            Console.WriteLine("");
            Console.WriteLine("Input number 1: ");
            cnum0 = Console.ReadLine();
            num0 = Convert.ToDouble(cnum0);
//          Console.WriteLine(num0);
            Console.WriteLine("Input number 2: ");
            cnum1 = Console.ReadLine();
            num1 = Convert.ToDouble(cnum1);
            //          Console.WriteLine(num1);
            Console.WriteLine("");
            Console.WriteLine("Division: ");
            Console.WriteLine(cpa1.checkPrimeD(num0, num1));
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
