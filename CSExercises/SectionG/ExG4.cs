using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] score = { 63, 29, 75, 82, 55 };
            int l = score.GetLength(0);
            SortByScore(name, score);
            for (int i = 0; i < l; i++)
                Console.WriteLine("{0}\t{1}", name[i], score[i]);
            SortByName(name, score);
            for (int i = 0; i < l; i++)
                Console.WriteLine("{0}\t{1}", name[i], score[i]);
        }
        public static void SortByName(string[] name, int[] score)
        {
            int l = name.GetLength(0);
            for (int i = 0; i < l - 1; i++)
                for (int j = i + 1; j < l; j++)
                    if ((name[i].CompareTo(name[j]))>0)
                    {
                        string st = name[i]; name[i] = name[j]; name[j] = st;
                        int t = score[i]; score[i] = score[j]; score[j] = t;
                    }
            return ;
        }
        public static void SortByScore(string[] name, int[] score)
        {
            int l = score.GetLength(0);
            for (int i = 0; i < l - 1; i++)
                for (int j = i + 1; j < l; j++)
                    if ((score[i]<score[j]))
                    {
                        string st = name[i]; name[i] = name[j]; name[j] = st;
                        int t = score[i]; score[i] = score[j]; score[j] = t;
                    }
            return ;
        }
    }
}
