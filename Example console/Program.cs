﻿using System;
using System.Xml.Schema;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter number");
        int i = int.Parse(Console.ReadLine()!);

        if (i > 0)
        {
            int c = 10;
            int a = i + c;

            for (int N1 = i; N1 <= a; N1++)
                Console.WriteLine(N1);
        }
        else
        {
            int c = -10;
            int a = i + c;

            for (int N1 = i; N1 >= a; N1--)
                Console.WriteLine(N1);

        }









    }
}
