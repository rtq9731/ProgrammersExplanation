using System;
using System.Collections.Generic;
using System.Linq;

// 신고 결과 받기 

//신입사원 무지는 게시판 불량 이용자를 신고하고 처리 결과를 메일로 발송하는 시스템을 개발하려 합니다.무지가 개발하려는 시스템은 다음과 같습니다.
//각 유저는 한 번에 한 명의 유저를 신고할 수 있습니다.
//신고 횟수에 제한은 없습니다.서로 다른 유저를 계속해서 신고할 수 있습니다.
//한 유저를 여러 번 신고할 수도 있지만, 동일한 유저에 대한 신고 횟수는 1회로 처리됩니다.
//k번 이상 신고된 유저는 게시판 이용이 정지되며, 해당 유저를 신고한 모든 유저에게 정지 사실을 메일로 발송합니다.
//유저가 신고한 모든 내용을 취합하여 마지막에 한꺼번에 게시판 이용 정지를 시키면서 정지 메일을 발송합니다.

public class Solution
{
    static string[] id_list = { "muzi", "frodo", "apeach", "neo" };
    static string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
    static int k = 2;

    static Dictionary<string, List<string>> reportDict = new Dictionary<string, List<string>>();

    public static void Main()
    {
        solution(id_list, report, k);
    }

    public static int[] solution(string[] id_list, string[] report, int k)
    {
        List<int> answer = new List<int>();

        int i;
        for (i = 0; i < id_list.Length; i++)
        {
            answer.Add(0);
        }

        for (i = 0; i < report.Length; i++)
        {
            string[] str = report[i].Split(' '); // 0번 신고자 1번 신고 당한 사람

            if (reportDict.TryGetValue(str[1], out List<string> repoter)) // 값을 가져온다
            {
                if (!repoter.Contains(str[0])) // 이미 신고 한 사람이 아니라면
                {
                    repoter.Add(str[0]); // 신고자 추가
                }
            }
            else
            {
                List<string> temp = new List<string>() { str[0] };
                reportDict.Add(str[1], temp); // 신고자를 넣은 채로 새 리스트를 만들어 딕셔너리에 추가
            }
        }

        for (i = 0; i < id_list.Length; i++)
        {
            if(reportDict.ContainsKey(id_list[i]))
            {
                if (reportDict[id_list[i]].Count >= k)
                {
                    for (int j = 0; j < reportDict[id_list[i]].Count; j++)
                    {
                        answer[id_list.ToList().IndexOf(reportDict[id_list[i]][j])]++;
                    }
                }
            }
        }

        for (i = 0; i < answer.Count; i++)
        {
            Console.Write(answer[i]);
        }

        return answer.ToArray();
    }
}