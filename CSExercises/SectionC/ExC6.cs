using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            int tvsQty = Convert.ToInt32(Console.ReadLine());
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            int mp3Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Round(CalculateTotalPrice(tvsQty, dvdQty, mp3Qty)));
        }

        public static double CalculateTotalPrice(int tvsQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double result = tvsQty * 900 + dvdQty * 500;
            if (result > 10000)
                result = result * 0.85;
            else
                if (result > 5000)
                    result = result * 0.9;
            return result + mp3Qty * 700;
        }
    }
}