using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string str = Console.ReadLine();
            Console.WriteLine(CalculateIncome(str));
        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            double salarydb1 = Convert.ToDouble(salaryStr);
            salarydb1 = salarydb1 * 1.13;
            string result = salarydb1.ToString("C2");
            //string result = salarydb1.ToString("{0:C}");
            return result;
        }
    }
}
