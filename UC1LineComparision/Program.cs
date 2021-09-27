using System;

namespace UC1LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1 value");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 value");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y1 value");
           int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 value");
            int y2 = int.Parse(Console.ReadLine());

            double length= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)* (y2 - y1));
            Console.WriteLine("Length is : "+length);

        }
    }
}
