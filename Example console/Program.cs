﻿using System;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student Roll Number:");
        int rollNumber = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Name of the Student:");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter the Marks for Physics:");
        int physicsMarks = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Marks for Chemistry:");
        int chemistryMarks = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Marks for Computer Application:");
        int computerMarks = int.Parse(Console.ReadLine()!);

        int total = physicsMarks + chemistryMarks + computerMarks;
        int per = (total) / 3;
        if (per >= 80)
        {
            Console.WriteLine("First Division");
        }
        else if (per  >= 50 && per < 60)
        {
            Console.WriteLine("Second Division");
        }
        else if (per >= 40 && per < 50)
        {
            Console.WriteLine("pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }


        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Physics Marks: " + physicsMarks);
        Console.WriteLine("Chemistry Marks: " + chemistryMarks);
        Console.WriteLine("Computer Application Marks: " + computerMarks);
        Console.WriteLine("the total marks is: " + (total));
        Console.WriteLine("the percentage is: " + per + "%");
         Console.WriteLine("division: " + per );



        
    }
}
