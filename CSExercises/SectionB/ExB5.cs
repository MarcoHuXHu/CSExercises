using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string inputStr = Console.ReadLine();
            double inputDb1 = Convert.ToDouble(inputStr);
            Console.WriteLine(CalculateY(inputDb1));
        }

        public static double CalculateY(double x)
        {
            //YOUR CODE HERE
            return 2.0*x*x-4.0*x+3.0;
        }
    }
}
