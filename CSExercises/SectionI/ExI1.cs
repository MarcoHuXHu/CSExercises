using System;
using CSExercises;

namespace CSExercises
{
    //You are required to take as input an amount (dollar.cents).  
    //Assume that the amount is between 5 cents (inputted as 0.05) and 
    //3 dollars 50 cents (inputted as 3.50).  Further assume that we would 
    //always input nearest to 5 cents (i.e., values like 2.23 are not keyed in).  
    //The duty of your program is to dispense this amount (accurately!) using a combination of 
    //coins.  We have coins of denomination 100, 50, 20, 10 and 5 cents.  More than one coin of 
    //a denomination can be used.  
    //Yeah I know what you are thinking – simply issue all five cent coins; right?  
    //Cannot!- easy but no challenge.  
    //We are requesting the program to use the “minimum number of coins” principle.  
    //For example, if a request were made for 1.95 then the computer would issue one 100-cent coin, 
    //one 50-cent coin, two 20-cent coins and one 5-cent coin.  

    //The trick is to always start with the largest denomination and slowly go down.  
    //Try your luck – but don’t loose money!  

    public class ExI1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if ((amount < 0) || (amount > 3.5)) return ;
            //YOUR CODE HERE
            int num = Convert.ToInt32(amount * 100);
            int[] coins = { 5, 10, 20, 50, 100 };
            int[]  f = new int[500];
            int[,] g = new int[500, 5];
            //initialization
            f[5] = 1; g[5, 0] = 1;
            f[10] = 1; g[10, 1] = 1;
            f[20] = 1; g[20, 2] = 1;
            f[50] = 1; g[50, 3] = 1;
            f[100] = 1; g[100, 4] = 1;
            //search
            for (int i = 0; i < num; i = i + 5)
                if (f[i]>0)
                    for (int j = 0; j < 5; j++)
                        if ((f[i + coins[j]] == 0) || (f[i + coins[j]] > f[i] + 1))
                        {
                            f[i + coins[j]] = f[i] + 1;
                            for (int k = 0; k < 5; k++)
                                g[i + coins[j], k] = g[i, k];
                            g[i + coins[j], j] = g[i, j] + 1;
                        }
            //Console.WriteLine(f[num]);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < g[num, i]; j++)
                    Console.WriteLine("{0}c", coins[i]);
        }
    }
}
