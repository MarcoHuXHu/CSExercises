using System;

namespace CSExercises
{
    //Write a C# program that would sort a numeric array in descending order 
    //using the simplified selection sort method described.

    //At the end of each pass print out the array to know the progress!

    public class ExF2
    {
        public static void Main(string[] args)
        {
            int[] list = new int[] {86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79};

            //Sort(list);
            qsort(0, list.GetLength(0)-1, list);
            for (int k = 0; k < list.Length; k++)
            {
                Console.Write(list[k] + " ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] values)
        {
            //YOUR CODE HERE
            //Sort the list
            for (int i=0; i<values.GetLength(0)-1; i++)
                for (int j=i+1; j<values.GetLength(0); j++)
                    if (values[i]<values[j])
                    {
                        int t = values[i]; values[i] = values[j]; values[j] = t;
                    }
        }
        public static void qsort(int l, int r, int[] a)
        {
            int i = l; int j = r;
            Random ran = new Random();
            int x = a[ran.Next(l, r)];
            while (i < j)
            {
                while ((a[i] > x) && (i < r)) i++;
                while ((a[j] < x) && (j > l)) j--;
                if (i<j)
                {
                    int t = a[i]; a[i] = a[j]; a[j] = t;
                }
            }
            if (j > l) qsort(l, j-1, a);
            if (i < r) qsort(i+1, r, a);
        }
    }
}
