using CursoNelioAula1652.Services;
using System;

namespace CursoNelioAula1652
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Square(a);
            Console.WriteLine(result);
        }
    }
}