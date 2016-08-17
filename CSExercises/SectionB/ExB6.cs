using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double x1, x2, y1, y2;
            string str;
            str = Console.ReadLine();
            x1 = Convert.ToDouble(str);
            str = Console.ReadLine();
            y1 = Convert.ToDouble(str);
            str = Console.ReadLine();
            x2 = Convert.ToDouble(str);
            str = Console.ReadLine();
            y2 = Convert.ToDouble(str);
            Console.WriteLine(CalculateDistance(x1, y1, x2, y2));
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
        }
    }
}
