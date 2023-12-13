using System.Collections.Generic;
using System.Linq;

public class Solution
{
        public int[] solution(int[] arr)
        {
            // 리스트로 치환
            List<int> arr_list = new List<int>(arr);

            // 가장 작은 수를 찾기
            int min = arr.Min();

            // 해당 배열 제거
            arr_list.RemoveAll(num => num == min);

            if (arr_list.Count == 0)
            {
                arr_list.Add(-1);
            }
            
            return arr_list.ToArray();
        }
}