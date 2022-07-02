using System;

namespace _03.NumbersAndEnglish
{
    class Solution
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.WriteLine(sol.solution("one4seveneight"));
        }

        public int solution(string s)
        {
            string answerString = "";

            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] < '0' || s[i] > '9') // 0 보다 작고 9보다 큰 아스키 코드라면 분명 다른 문자임.
                {
                    temp += s[i];
                    switch (temp) 
                    {
                        case "zero":
                            answerString += "0";
                            temp = "";
                            break;
                        case "one":
                            answerString += "1";
                            temp = "";
                            break;
                        case "two":
                            answerString += "2";
                            temp = "";
                            break;
                        case "three":
                            answerString += "3";
                            temp = "";
                            break;
                        case "four":
                            answerString += "4";
                            temp = "";
                            break;
                        case "five":
                            answerString += "5";
                            temp = "";
                            break;
                        case "six":
                            answerString += "6";
                            temp = "";
                            break;
                        case "seven":
                            answerString += "7";
                            temp = "";
                            break;
                        case "eight":
                            answerString += "8";
                            temp = "";
                            break;
                        case "nine":
                            answerString += "9";
                            temp = "";
                            break;
                        default:
                            break;
                    } // 스위치문으로 문자열 변환
                }
                else
                {
                    answerString += s[i];
                }
            }

            return int.Parse(answerString);
        }
    }
}
