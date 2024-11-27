using System;
using CursoNelioAula1693.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CursoNelioAula1693
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();// metodo in line
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}