public class Solution {
    public string solution(string s) {
        string answer = "";
        
        //문자열을 2로 나눈 뒤 나머지가 0이면 짝수
        //길이/2-1 + 길이/2를 더해 반환
        if(s.Length%2==0)
        {
            answer = s[s.Length/2-1].ToString() + s[s.Length/2].ToString();
        }
        //물자열 길이가 홀수이면 길이 가운데 문자를 반환
        else
        {
            answer = s[s.Length/2].ToString();
        }
        
        return answer;
    }
}