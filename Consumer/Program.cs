using Figures;
using System;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Triangle triangle = new Triangle(ConsoleColor.Red);
            Square square = new Square(ConsoleColor.Green);
            printer.Print(triangle);
            printer.Print(square, 2);
            Console.ReadLine();
        }
    }
}
