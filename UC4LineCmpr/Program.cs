using System;

namespace UC4LineCmpr
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter coordinates for First line");
            Console.WriteLine("Enter values of the coordinates for first point(x1,y1)");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(x2,y2)");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            int a1, a2, b1, b2;
            Console.WriteLine("Enter coordintes for Second Line");
            Console.WriteLine("Enter values of the coordinates for first point(a1,b1)");
            a1 = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter values of the coordinates for second point(a2,b2)");
            a2 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());

            Neww obj = new Neww();
            double length1 = obj.getLength(x1, y1, x2, y2);
            double length2 = obj.getLength(a1, b1, a2, b2);

            obj.cmprValue(length1, length2);
            obj.isEqual(length1, length2);

            



        }
    }
}
