using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine($"There are {args.Length} / {args} arguments.");

        foreach(var a in args)
        {
            WriteLine(a);
        }
    }
}