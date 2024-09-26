using System;
using System.Collections.Generic;

namespace CursoNelioAula1540
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("alex");

            Console.WriteLine(set.Contains("Maria"));
        }
    }
}
