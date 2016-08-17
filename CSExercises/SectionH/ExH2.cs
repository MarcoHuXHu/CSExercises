namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1in, string s2in)
        {
            //YOUR CODE HERE
            string s1 = s1in.ToUpper();
            string s2 = s2in.ToUpper();
            int len = s2.Length;
            int[] T = new int[len + 1];
            T[0] = -1; T[1] = 0;
            int cnd = 0; int pos = 2;
            //build partial match table
            while (pos<len)
            {
                if (s2[pos - 1] == s2[cnd]) //substring continues
                {
                    T[pos] = cnd + 1; cnd++; pos++;
                }
                else
                    if (cnd > 0) //substring cannot continue, fall back
                        cnd = T[cnd - 1];
                    else //run out of candidates, cnd = 0
                    {
                        T[pos] = 0; pos++;
                    }
            }
            //kmp search
            int m = 0; int i = 0;
            while (m+i<s1.Length)
            {
                if (s1[m + i] == s2[i])
                {
                    if (i == len - 1) return m;
                    i++;
                }
                else
                    if (T[i]>-1) //using the partial match table
                    {
                        m = m + i - T[i]; i = T[i];
                    }
                    else //T[i]==-1, means it goes to s2[0];
                    {
                        m++; i = 0;
                    }
            }
            return -1;
        }
    }
}
