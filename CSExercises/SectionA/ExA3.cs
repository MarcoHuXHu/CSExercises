using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            string strin;
            strin = Console.ReadLine();
            int intinput, intresult;
            intinput = Convert.ToInt32(strin);
            intresult = square(intinput);
            Console.WriteLine(intresult);
        }

        public static int square(int x)
        {
            //PUT YOUR CODE HERE
            return x*x;

        }
    }
}
