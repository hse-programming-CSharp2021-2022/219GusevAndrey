using System;

namespace CW4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = Int32.Parse(Console.ReadLine());
            int[] myMass = new int[N];
            for (int i = 0; i < N; i++)
            {
                myMass[i] = Int32.Parse(Console.ReadLine());
            }

            var k = 0;
            for (int i = 0; i < N - k; i++)
            {
                if (i + 1 < N - k)
                {
                    if ((myMass[i] + myMass[i + 1]) % 3 == 0)
                    {
                        k++;
                        myMass[i + 1] = myMass[i] * myMass[i + 1];
                        for (int j = i; j < N - 1; j++)
                        {
                            myMass[j] = myMass[j + 1];
                        }
                    }
                }
                else
                {
                    k++;
                }
            } 
            for (int i = 0; i < N - k; i++)
            {
                if (myMass[i] > 0)
                    Console.Write("" + myMass[i] + " ");
            }
        }
    }
}