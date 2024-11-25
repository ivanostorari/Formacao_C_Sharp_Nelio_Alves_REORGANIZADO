
using CursoNelioAula1656.Services;
using System;

namespace CursoNelioAula1656
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // fica muito verboso, então muito mais prático usar a função (CalculationService.Sum);

            double result = op.Invoke(a, b);
            // pode usar outra função chamada Invoke é outra sintaxe alternativa.
            Console.WriteLine(result);
        }
    }
}