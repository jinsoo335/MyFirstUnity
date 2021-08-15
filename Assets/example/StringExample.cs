using UnityEngine;

public class StringExample : MonoBehaviour
{
    // 1. Length : ���ڿ��� ���� ��ȯ
    // 2. IndexOf() : �μ��� �� ��° �������� ��ȯ. ��ȯ, ���ٸ� -1 ��
    // 3. Replace() : Ư�� ���ڿ��� ġȯ(�ٲ�)
    // 4. Split() : Ư�� ���ڸ� �������� ���ڿ��� ������ �迭�� ��ȯ
    // 5. SubString() : ���ڿ��� �κ������� �߶��ִ� ����
    // 6. string.Format()
    // 7. string ����ȯ    .. string�� �������̱� ������ ���� ������ �޼ҵ带 ����ؾ���

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
        Debug.Log(str1.Replace("l", "5"));    // He55o  ������ �ִٸ� ������ ��� �ٲ�

        // 4. Split()
        string str3 = "abcedf";
        string[] arr = str3.Split('c');     // c �� �������� ������ ������ c�� ��� �ʿ��� ������ ����
        Debug.Log(arr.Length);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);

        string str4 = "ö��, ����, ����, ����, �ǻ�";
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

        // 7. string ����ȯ
        int num = 1;
        string numStr = num.ToString();     // "1"      (string)num -> �Ұ���

        int num2 = int.Parse(numStr);      // 1
        float num3 = float.Parse(numStr);  // 1.0f 
    }

}
