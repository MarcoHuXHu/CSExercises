namespace CSExercises
{
    public class ExH1
    {
        public static bool InString(string s1, string s2)   //Find S2 in S1; Using KMP
        {
            //YOUR CODE HERE
            if (ExH2.FindWord(s1,s2)>=0) return true;
            return false;
        }
    }
}
