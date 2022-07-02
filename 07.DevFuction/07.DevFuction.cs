using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.DevFuction
{
    public class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            Dictionary<int, int> answer = new Dictionary<int, int>();

            int max = 0;

            for (int i = 0; i < progresses.Length; i++)
            {
                int day = 0;
                while(progresses[i] + day * speeds[i] < 100)
                {
                    day++;
                }

                if(day > max)
                {
                    max = day;
                }

                if(!answer.ContainsKey(max))
                {
                    answer.Add(max, 1);
                }
                else
                {
                    answer[max]++;
                }
            }

            return answer.Values.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 100, 100, 100, 93, 30, 55, 30, 50, 60, 40, 50 }, new int[] { 1, 1, 1, 1, 30, 5, 4, 5, 6, 7, 8 });
        }
    }
}
