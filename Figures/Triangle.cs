using System;

namespace Figures
{
    public class Triangle : BaseFifure
    {
        public Triangle(ConsoleColor color = ConsoleColor.White)
        {
            Color = color;
        }
        public override void Print()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("  *  {0} * * {0}*****", Environment.NewLine);
            Console.ResetColor();
        }
    }
}
