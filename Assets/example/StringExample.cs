using UnityEngine;

public class StringExample : MonoBehaviour
{
    // 1. Length : 문자열의 길이 반환
    // 2. IndexOf() : 인수가 몇 번째 글자인지 반환. 단환, 없다면 -1 반
    // 3. Replace() : 특정 문자열을 치환(바꿈)
    // 4. Split() : 특정 문자를 기준으로 문자열을 나누어 배열로 반환
    // 5. SubString() : 문자열을 부분적으로 잘라주는 역할
    // 6. string.Format()
    // 7. string 형변환    .. string은 참조형이기 때문에 따로 지정된 메소드를 사용해야함

    private void Start()
    {
        string str1 = "Hello";
        string str2 = "Hello World";

        // 1. Length
        Debug.Log(str1.Length); // 5
        Debug.Log(str2.Length); // 11

        // 2. IndexOf()
        Debug.Log(str1.IndexOf("e"));   // 1
        Debug.Log(str1.IndexOf("o"));   // 4

        // 3. Replace()
        Debug.Log(str1.Replace("l", "5"));    // He55o  여러개 있다면 여러개 모두 바꿈

        // 4. Split()
        string str3 = "abcedf";
        string[] arr = str3.Split('c');     // c 를 기준으로 나뉘기 때문에 c는 어느 쪽에도 속하지 않음
        Debug.Log(arr.Length);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);

        string str4 = "철수, 영희, 나리, 훈이, 뽀삐";
        string[] nameArr = str4.Split(',');

        foreach (string name in nameArr)
        {
            Debug.Log(name);
        }

        // 5. Substring
        string str5 = "tomato";
        Debug.Log(str5.Substring(2));   // mato
        Debug.Log(str5.Substring(1, 3)); // oma
        Debug.Log(str5.Substring(str5.IndexOf("o"), 3));    // oma

        // 6. string.Format()
        string newStr = string.Format("43 * 72 = {0}", 43 * 72);    // 43 * 72 = 3096
        Debug.Log(newStr);

        for (int i =2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Debug.Log(string.Format("{0} * {1} = {2}", i, j, i * j));
            }
        }

        // 7. string 형변환
        int num = 1;
        string numStr = num.ToString();     // "1"      (string)num -> 불가능

        int num2 = int.Parse(numStr);      // 1
        float num3 = float.Parse(numStr);  // 1.0f 
    }

}
