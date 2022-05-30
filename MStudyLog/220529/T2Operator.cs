using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220529
{

    public class T2Operator
    {
        
        
        public T2Operator()
        {
            Point point = new Point();
            point.X = 1;
            point.Y = 1;
            Point point2 = new Point();
            point2.X = 2;
            point2.Y = 2;

            Point point3 = point + point2;

        }

    }
    class Point
    {
        public int X;
        public int Y;

        public static Point operator +(Point p1,Point p2)
        {
            Point p= new Point();
            p.X = p1.X + p2.X;
            p.Y = p1.Y + p2.Y;
            return p;
        }
    }
}
