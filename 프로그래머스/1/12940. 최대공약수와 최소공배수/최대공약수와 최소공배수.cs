public class Solution {
    public int[] solution(int n, int m) {
        int gcd = GetGCD(n, m); // 최대공약수 계산
        int lcm = GetLCM(n, m, gcd); // 최소공배수 계산
        
        // 최대공약수와 최소공배수를 배열에 저장하여 반환
        return new int[] { gcd, lcm };
    }
    
    // 최대공약수를 계산하는 함수
    private int GetGCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    // 최소공배수를 계산하는 함수
    private int GetLCM(int a, int b, int gcd) {
        return (a * b) / gcd;
    }
}
