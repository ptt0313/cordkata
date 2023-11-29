public class Solution {
    public long solution(long a, long b) {
        long answer = 0;
      return  a <= b? b * (b+1)/2 - (a-1) * a/2 : a* (a+1)/2 - (b-1) * b/2;


    }
}