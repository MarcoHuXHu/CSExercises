using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string inputStr = Console.ReadLine();
            double inputDb1 = Convert.ToDouble(inputStr);
            Console.WriteLine("{0:0.00}", CalculateFare(inputDb1));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            return Math.Round((2.4 + distance * 0.4), 1);
        }
    }
}
