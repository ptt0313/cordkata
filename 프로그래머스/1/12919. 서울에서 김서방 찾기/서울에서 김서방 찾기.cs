using System;
public class Solution {
    public string solution(string[] seoul) {
        
int findIndex = Array.FindIndex(seoul, i => i == "Kim");
        string answer = "김서방은 "+findIndex+"에 있다";


        return answer;
    }
}