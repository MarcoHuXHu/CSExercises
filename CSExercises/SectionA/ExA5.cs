﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number as 
    //input and prints the number with 2 decimal points in the output.
    //Example: 
    //  Input       Output
    //  100.1	    100.10
    //  0	        0.00
    //  3.232	    3.23
    //  4.555	    4.55


    public class ExA5
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            double inputDbl = Convert.ToDouble(inputStr);
            Console.WriteLine("{0:0.00}",inputDbl);
            //YOUR CODE HERE

        }

    }
}
