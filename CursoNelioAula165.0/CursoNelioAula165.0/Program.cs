using CursoNelioAula1650.Services;
using System;

namespace CursoNelioAula1650
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);
        }
    }
}