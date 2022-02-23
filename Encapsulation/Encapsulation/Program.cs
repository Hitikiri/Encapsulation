using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectange rectange = new Rectange();
            rectange.a = 3;
            rectange.b = 5;
            Console.WriteLine(rectange.CalculateArea());
        }
    }
}