using System;
using Figures;

namespace Consumer
{
    public class Printer
    {
        public void Print(BaseFifure figure, byte copyCount = 1)
        {
            for ( int i = 0 ; i < copyCount ; i++ )
            {
                figure.Print();
            }
        }
    }
}
