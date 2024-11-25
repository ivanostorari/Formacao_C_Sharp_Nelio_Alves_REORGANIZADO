using CursoNelioAula1655.Services;
using System;

namespace CursoNelioAula1655
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Square;

            // da erro, a função Square não casa com a definição de delegate, só pode usar com as funções que casam com a assinatura como (Sum, Max e Min etc.)

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}