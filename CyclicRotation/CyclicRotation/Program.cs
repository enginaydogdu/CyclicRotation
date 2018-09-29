using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new [] {3, 8, 9, 7, 6};
            int[] newArr = Solution.solution(A, 3);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            
            Console.Read();
        }
    }

    public static class Solution
    {
        public static int[] solution(int[] A, int K)
        {
            for (int i = 0; i < K; i++)
            {
                int last = A[A.Length - 1];
                for (int j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = last;
            }
            
            return A;
        }
    }
}
