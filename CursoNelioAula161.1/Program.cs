using System;
using CursoNelioAula1611.Extensions;

public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());


    }
}