  using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsArmstrongNumber(n))
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");
        }
        public static bool IsArmstrongNumber(int n)
        {
            /*
            //YOUR CODE HERE
            for (int i = 0; i < 10; i++)
                for (int j = i; j < 10; j++)
                    for (int k = j; k < 10; k++)
                        if (n == i * i * i + j * j * j + k * k * k)
                        {
                            Console.WriteLine("Armstrong Number");
                            return true;
                        }
            Console.WriteLine("Not Armstrong Number");
            return false;
            */
            int a = n / 100;
            int b = (n % 100) / 10;
            int c = n % 10;
            return (a * a * a + b * b * b + c * c * c == n);
        }
    }
}