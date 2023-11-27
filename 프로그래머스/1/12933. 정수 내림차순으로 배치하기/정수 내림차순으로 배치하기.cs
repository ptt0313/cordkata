using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        string separator = "";
        string nStr = n.ToString();
        Char[] nArr = nStr.ToCharArray();
        var dArr = from d in nArr orderby d descending select d;
        string result = String.Join(separator, dArr);
        answer = Convert.ToInt64(result);
        return answer;
    }
}