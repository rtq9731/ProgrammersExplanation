using System;
using System.Linq;

namespace _02.Lotto
{
    class Solution
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 44, 1, 0, 0, 31, 25 }, new int[] { 31, 10, 45, 1, 6, 19 });
        }

        public int[] solution(int[] lottos, int[] win_nums)
        {
            int min = 0;
            int max = 0;

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    max++;
                    continue;
                }

                for (int j = 0; j < win_nums.Length; j++)
                {
                    if(win_nums[j] == lottos[i])
                    {
                        min++;
                        max++;
                        break;
                    }
                }
            }

            int[] answer = new int[]{ GetLottoLank(max), GetLottoLank(min) };

            return answer;
        }

        public int GetLottoLank(int current)
        {
            switch (current)
            {
                case 2:
                    return 5;
                case 3:
                    return 4;
                case 4:
                    return 3;
                case 5:
                    return 2;
                case 6:
                    return 1;
                default:
                    return 6;
            }
        }
    }
}
