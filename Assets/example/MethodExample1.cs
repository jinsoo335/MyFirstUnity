using UnityEngine;

public class MethodExample1 : MonoBehaviour
{
    // �޼��� �����ε� : �޼����� �ĺ��ڴ� ������ �Ű������� �ٸ� ���� �ż��带 �����ϴ� ��

    private void Start()
    {
        Debug.Log(Add(1, 2)); // 3
        Debug.Log(Add(1.1f, 22.2f));
        
    }




    int Add(int a, int b)
    {
        return (a + b);
    }
    float Add(float a, float b)
    {
        return (a + b);
    }

}
