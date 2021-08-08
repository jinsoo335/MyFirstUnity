using UnityEngine;

public class MethodExample : MonoBehaviour
{
    /*
      - �޼����� �⺻ ����
      ����_������ ��ȯ_Ÿ�� �޼���_�̸�(�Ű�����){
        .. ������ �ڵ�
      }
     */

    // 1. �ǻ�Ȱ���� ���� ���̴� �޼��� : Half -> �Է°��� ������ ������ ��ȯ���ִ� �޼���
    // 2. ��ȯ���� ���� �޼��� : PrintNumber
    // 3. �Ű������� ���� �޼��� : GetTen
    // 4. �Ű������� ���� ���� �޼��� : Add
    // 5. ��ȯ���� �ް������� ���� �޼��� : PrintHello

    float Half(float num)
    {
        return num / 2;
    }

    void PrintNumber(int num)
    {
        Debug.Log(num);
    }

    int GetTen()
    {
        return 10;
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    void PrintHello()
    {
        Debug.Log("Hello");
    }

    void Start()
    {
        //float result = Half(10);
        //Debug.Log(result);

        GetTen();  // 10
        Add(1, 3); // 4 

        PrintHello(); // console -> "Hello"

    }


}
