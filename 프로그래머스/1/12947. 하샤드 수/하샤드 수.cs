using System;

public class Solution {
    public bool solution(int x) {
        //정수를 string형으로 변환
        string s = x.ToString();
        
        //정수 sum를 선언하고 반복문으로 한 자리씩 더함
        int sum = 0;
        foreach(char c in s)
        {
            sum += int.Parse(c.ToString());
        }
        //x를 sum으로 나누었을 때 나머지가 0이면 하샤드 수 이므로 true 리턴
        if(x%sum==0) return true;
        else return false;
    }
}