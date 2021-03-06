using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.
    
    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1<num2)
            {
                int t = num1; num1 = num2; num2 = t;
            }
            int hcf = 0; int lcm = 0;
            CalculateHCFAndLCM(num1, num2,ref hcf,ref lcm);
            Console.WriteLine(hcf);//test need 2 writeline(0);
            Console.WriteLine(lcm);
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            //Don't worry about the use of "ref" keyword here. 
            //At the end of the method, assign the HCF value to the hcf parameter
            //and LCM to the lcm parameter. hcf = <some value>; lcm=<some value>;
            int r = a % b;
            lcm = a * b;
            while (r!=0)
            {
                a = b; b = r; r = a % b;
            }
            hcf = b; lcm = lcm / b;
            return;
        }
    }
}
