using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
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
            return Math.Ceiling((2.4 + distance * 0.4)*10.0)/10.0;
        }
    }
}
