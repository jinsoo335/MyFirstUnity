using UnityEngine;

public class ExceptionExample : MonoBehaviour
{
    // ����(exception) : ����(��Ÿ��)
    // - ������ ���� : �����Ű�� �� ������ �ܰ迡�� �߻��ϴ� ����
    // - ��Ÿ�� ���� : ���� ���� �߻��ϴ� ���� -> ���α׷��� ������������ ����

    // * try, catch, finally    
    // try -> ���ܰ� ���� ���� ����
    // catch  -> ���ܰ� �Ͼ�� ������ ����
    // finally -> ����ó���� ���� �� ������ ����

    void Start()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        try
        {
            User user = null;
            Debug.Log(user.name);
            for (int i = 0; i < 10; i++)
            {
                Debug.Log(arr[i]);
                sum += arr[i];
            }
        }
        catch (System.Exception exception)
        {
            Debug.Log(exception.Message);
        }
        finally
        {
            Debug.Log(sum);
        }


        Debug.Log("�Ϸ�!");

    }
}
