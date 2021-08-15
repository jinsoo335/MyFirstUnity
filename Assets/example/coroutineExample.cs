using UnityEngine;
using System.Collections;


public class coroutineExample : MonoBehaviour
{
    // ���� �ð� �Ŀ� �޼��尡 ���� -> Invoke
    // 1. �޼��忡 �μ��� ���� �� ����.
    // 2. ���� �ð� �Ŀ� �޼��带 ���� �ϴ� �� ���� �ٸ� ����� ����.

    // -> �ڷ�ƾ!

    /*
     *  - �ڷ�ƾ�� ����
     *  IEnumerator �ڷ�ƾ_�̸�(�Ű�����){
     *      yield return ��
     *  }
     */
    // * yeild return -> ȣ���ڿ��� ������� �ѱ�� ����

    private void Start()
    {
        StartCoroutine(First());
        Debug.Log("3");
    }

    IEnumerator First()
    {
        Debug.Log("1");
        yield return null;      // �ٽ� Start()�� ��� �Ѿ ..  �ҷ��� ������ ���ư� .. ���� �ٽ� ���ƿ�
        StartCoroutine(Second()); 
    }
    IEnumerator Second()
    {
        Debug.Log("2");  
        yield return null;
    }
    IEnumerator Third()
    {
        yield return null;
    }

}
