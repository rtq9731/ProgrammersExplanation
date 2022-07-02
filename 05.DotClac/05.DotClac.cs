using System;

namespace _05.DotClac
{
    public class Solution
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }

            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 1, 2, 3, 4 }, new int[] { -3, -1, 0, 2 });
        }
    }
}
