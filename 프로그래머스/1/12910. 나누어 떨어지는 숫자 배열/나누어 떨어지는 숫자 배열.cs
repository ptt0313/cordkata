using System.Collections.Generic;

public class Solution {

    public int[] solution(int[] arr, int divisor) {
    
    	//result 리스트생성
        List<int> result = new List<int>();
        
        //for문을써서 arr길이만큼 반복
        for(int i=0; i<arr.Length; i++)
        {
        	//arr의 배열이 divisor 와 나누어 나머지가 0일경우
            if(arr[i]%divisor == 0)
            {
            	//리스트에 추가
                result.Add(arr[i]);
            }
        }
        
        //추가된 리스트가 없을경우 -1을 리턴
        if (result.Count == 0)
            return new int[] { -1 };
            
        //리스트를 오름차순으로 정렬해준다.
        result.Sort();
        
        //ToArray()배열을 리턴함
        return result.ToArray();
    }
}