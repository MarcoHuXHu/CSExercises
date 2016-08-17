using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double inputdb1, inputdb2, inputdb3;
            string str;
            str = Console.ReadLine();
            inputdb1 = Convert.ToDouble(str);
            str = Console.ReadLine();
            inputdb2 = Convert.ToDouble(str);
            str = Console.ReadLine();
            inputdb3 = Convert.ToDouble(str);
            Console.WriteLine("{0:0.###}",CalculateArea(inputdb1, inputdb2, inputdb3));

        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
    }
}