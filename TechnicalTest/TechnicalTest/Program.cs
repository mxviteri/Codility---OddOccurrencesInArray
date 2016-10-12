using System;
using System.Linq;

namespace TechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine(test.solution(A));
            Console.Read();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            var oddValue = A
                .GroupBy(e => e)
                .Where(e => e.Count()%2 != 0)
                .Select(e => e.FirstOrDefault());

            return oddValue.FirstOrDefault();
        }
    }
}
