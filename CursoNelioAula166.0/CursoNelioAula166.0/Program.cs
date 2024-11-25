
using CursoNelioAula1660.Services;
using System;

namespace CursoNelioAula1660
{

    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            //posso também alternativamente colocar só op(a, b); que funciona da mesma forma.
        }
    }
}