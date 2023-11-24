using System;

public class Solution {
    public long solution(long n) {
        long answer = -1;
        long max = n/2;
        for(int x = 1; x <= max+1; x++)
        {
            if(n % x == 0 && n / x == x)
            {
                answer = (long)Math.Pow(x+1,2);
                break;
            }
    }
        return answer;
}
}