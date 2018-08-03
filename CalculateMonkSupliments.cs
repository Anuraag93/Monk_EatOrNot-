using System;

namespace Monk_github
{
    public class CalculateMonkSupliments : ICalculateMonkSupliments
    {
        private readonly int[] expected;
        private int index;
        private int count;
        
        public CalculateMonkSupliments(int[] _expected, int _index)
        {
            expected = _expected;
            index = _index;
            count = index - 1; 
        }
        public bool IsMonkSatisfied(int[,] a, int n, int cumV, int cumC, int cumF, int cumP)
        {
            bool isTermination = cumV == 0 && cumC == 0 && cumF == 0 && cumP == 0;
            if (isTermination)
            {
                Console.WriteLine("returns true : " + cumV + " "+ cumC + " "+ cumF + " "+ cumP + " " + n + " ");
                return true;
            }
            if (n == 0 && !isTermination)
            {
                Console.WriteLine("***************************** returns false : " + cumV + " "+ cumC + " "+ cumF + " "+ cumP + " " + n + " ");
                return false;
            }
 
            if (cumV > expected[0] || cumC > expected[1] || cumF > expected[2] || cumP > expected[3])
            {
                Console.WriteLine("cumV is greater " + cumV + " "+ cumC + " "+ cumF + " "+ cumP + " ");
                return IsMonkSatisfied(a, n - 1, cumV, cumC, cumF, cumP);
            }

                Console.WriteLine("cummulative Values: " + cumV + " "+ cumC + " "+ cumF + " "+ cumP + " " + n +" ");
            return IsMonkSatisfied(a, n - 1, cumV, cumC, cumF, cumP) ||
                                 IsMonkSatisfied(a, n - 1, cumV - a[n - 1, 0], cumC - a[n - 1, 1], cumF - a[n - 1, 2], cumP - a[n - 1, 3]);
        }
        // public bool IsMonkSatisfied(int[,] fruits, int  row, int v, int c, int f, int p)
        // {
        //     // try
        //     // {
        //         if(v == 0 && c == 0 && f == 0 && p == 0)
        //         {
        //             return true;
        //         }   
        //         if(index == 0)
        //         {
        //             return false;
        //         }
                
        //         if(v < 0 || c < 0 || f < 0 || p < 0|| row == -1 )
        //         {
                    
        //             if(count == 0)
        //             {
        //                 index--;
        //                 count = index - 1;
        //             }
        //             else
        //             {
        //                 count--; 
        //             }
        //             return IsMonkSatisfied(fruits, count, expected[0] - fruits[index,0], expected[1] - fruits[index,1], expected[2] - fruits[index,2], expected[3] - fruits[index,3]);
        //         }
                
        //         return IsMonkSatisfied(fruits, row-1, v - fruits[row,0], c - fruits[row,1], f - fruits[row,2], p - fruits[row,3]);
        //     // }
        //     // catch(Exception ex)
        //     // {
        //     //     Console.WriteLine("this is the details : index " + index + " : row " + index + " : count " + count);
        //     //     return false;
        //     // }
        // }
    }    
}