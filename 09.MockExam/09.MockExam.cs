using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.MockExam
{
    public class Solution
    {
        public int[] solution(int[] answers)
        {
            List<int> result = new List<int>();

            int[][] peopleAnswers = new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 2, 3, 2, 4, 2, 5 }, new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 } };

            List<int> scroes = new List<int> { 0, 0, 0 };

            for (int i = 0; i < answers.Length; i++)
            {
                for (int j = 0; j < peopleAnswers.Length; j++)
                {
                    if(answers[i] == peopleAnswers[j][i % peopleAnswers[j].Length])
                    {
                        scroes[j]++;
                    }
                }
            }

            for (int i = 0; i < scroes.Count; i++)
            {
                if(scroes.FindAll(item => item > scroes[i]).Count < 1)
                {
                    result.Add(i + 1);
                }
            }

            return result.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 1, 3, 2, 4, 2 });
        }
    }
}
