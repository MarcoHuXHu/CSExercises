namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.

        public static string Hex(int i)
        {
            //YOUR CODE HERE
            char[] HexNum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int n = i;
            string str = "";
            while (n!=0)
            {
                str = HexNum[n % 16] + str;
                n = n / 16;
            }
            return str;
        }
    }
}
