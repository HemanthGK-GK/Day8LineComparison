using System;
using System.Collections.Generic;
using System.Text;

namespace UC3Compare2Length
{
    class Neww
    {
        public double getLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length is : " + length);
            return length;
        }
    }
}
