using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace _08.K_Num
{
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();

            string str = "";

            for (int i = 0; i < array.Length; i++)
            {
                str += (char)array[i];
            }


            List<int> tempList = new List<int>();
            string tempStr = "";
            for (int i = 0; i < commands.Length / 3; i++)
            {
                tempStr = "";
                tempList.Clear();

                for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    tempStr += (char)array[j];
                }
                for (int k = 0; k < tempStr.Length; k++)
                {
                    tempList.Add((int)tempStr[k]);
                }

                tempList.Sort();
                answer.Add(tempList[commands[i, 2] - 1]);
            }

            return answer.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { {2, 5, 3}, { 4, 4, 1 }, {1, 7, 3} });
        }
    }
}
