using System;
using System.Collections.Generic;
using System.Text;

namespace UC4LineCmpr
{
    class Neww
    {
        public double getLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length is : " + length);
            return length;
        }

        public void cmprValue(double len1,double len2)
        {
            int cmprVal = len1.CompareTo(len2);
            if (cmprVal == 0)
                Console.WriteLine("Value of both the lines are equal");
            else if (cmprVal > 0)
                Console.WriteLine("Value of line1 is greater than line2");
            else
                Console.WriteLine("Value of line1 is smaller than line2");
        }
        public void isEqual(double len1, double len2)
        {
            if (len1.Equals(len2))
                Console.WriteLine("Value of both the lines are equal");
            else
                Console.WriteLine("Value of both the lines are not equal");
        }
    }

    
}

