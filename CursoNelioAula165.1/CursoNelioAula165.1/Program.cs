using CursoNelioAula1651.Services;
using System;

namespace CursoNelioAula1651
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Max(a, b);
            Console.WriteLine(result);
        }
    }
}