using System;

namespace _04.PlusMinus
{
    public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                answer += (signs[i] ? absolutes[i] : -absolutes[i]);
            }

            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 4, 7, 12 }, new bool[] { true, false, true });
        }
    }
}
