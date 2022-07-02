using System;
using System.Collections.Generic;

namespace _06.MakePrimeNum
{
    class Solution
    {
        List<int[]> answers = new List<int[]>();

        public int solution(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(j == i)
                    {
                        continue;
                    }

                    for (int k = 0; k < nums.Length; k++)
                    {
                        if(k == j || k == i)
                        {
                            continue;
                        }

                        if (IsPrimeNum(nums[i] + nums[j] + nums[k]))
                        {
                            if(IsOnly(nums[i], nums[j], nums[k]))
                            {
                                Console.WriteLine($"{nums[i]} + {nums[j]} + {nums[k]} 는 {nums[i] + nums[j] + nums[k]}로, 소수입니다.");

                                answers.Add(new int[] { nums[i], nums[j], nums[k] });

                                answer++;
                            }
                        }

                    }
                }
            }

            Console.WriteLine(answer);
            return answer;
        }

        public bool IsOnly(int a, int b, int c)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                int sameCount = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (answers[i][j] == a)
                    {
                        sameCount++;
                    }

                    if (answers[i][j] == b)
                    {
                        sameCount++;
                    }

                    if (answers[i][j] == c)
                    {
                        sameCount++;
                    }
                }

                if(sameCount >= 3)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPrimeNum(int num)
        {
            if(num == 2) // 2는 유일한 소수 짝수임.
            {
                return true; 
            }

            if (num % 2 == 0) // 2가 아닌 짝수 중엔 소수가 없다
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if(num % i == 0) // 1이 아닌 수로 나눠지면 false
                {
                    return false;
                }
            }

            return true; // 여기까지 오면 조건 만족
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.solution(new int[] { 1, 2, 7, 6, 4 });
        }
    }
}
