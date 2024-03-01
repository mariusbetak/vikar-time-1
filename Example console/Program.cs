﻿public class Program
{
    public static void Main()
    {
        goodbeyworld("jeff");
        helloworld("bob", 2);
        noworld(1, 2, 3);
    }
    public static void goodbeyworld(string name)
    {
        Console.WriteLine($"hello and goodbey {name}");
    }
    public static void helloworld(string name, int cats)
    {
        Console.WriteLine($"hello world i have {cats} cats and my name is {name}");
    }
    public static void noworld(int counting, int counting2, int counting3)
    {
        Console.WriteLine($"i have {counting3} fish, {counting} dog and {counting2} cats.");
    }

}