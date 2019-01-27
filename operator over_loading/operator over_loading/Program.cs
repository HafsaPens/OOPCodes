using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_over_loading
{
    class point
    {
        public int X, Y, Z;
        public static point operator +(point p1,point p2)
        {
            return new point() { X = p1.X + p2.X, Y = p1.Y + p2.Y, Z = p1.Z + p2.Z };
        }
        public override string ToString()
        {
            return X + " " + Y + " " + Z + " ";
        }
        public static double  operator -(point p1,point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.Z - p1.Z) * (p2.Z - p1.Z));
        }
        public static bool operator >(point p1,point p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y && p1.Z > p2.Z; 
        }
        public static bool operator <(point p1,point p2)
        {
            return p1.X < p2.X && p1.Y < p2.Y && p1.Z < p2.Z;
        }
     
        

    }
    class program
    {
        static void Main()
        {
            point p1 = new point() { X = 10,Y=20,Z=30};
            point p2 = new point() { X = 5, Y = 10, Z = 15 };
            point p3 = p1 + p2;
            Console.WriteLine($"Point p3 formed by adding point p1 and point p2 is {p3}");
            Console.ReadKey();
            double distance = p2 - p1;
            Console.WriteLine($"Distance between two poiints in three dimensioin is {distance}");
            Console.ReadKey();
            if(p1>p2)
            {
                Console.WriteLine("p1 is greater than p2");
            }
            else
            {
                Console.WriteLine("p1 is lesser than p2");
            }
            Console.ReadKey();
        }
    }
    }

