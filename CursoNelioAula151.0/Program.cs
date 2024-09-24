using System;
using System.Collections.Generic;
using CursoNelioAula1510.Entities;

namespace CursoNelioAula1510
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gamil.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gamil.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
