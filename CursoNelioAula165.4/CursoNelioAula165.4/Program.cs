﻿using CursoNelioAula1654.Services;
using System;

namespace CursoNelioAula1654
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}