﻿using System;
using System.Collections.Generic;
using CursoNelioAula1683.Entities;

namespace CursoNelioAula1683
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

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => { p.Price += p.Price * 0.1; }); // in line 
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}