using UnityEngine;

public class AnonymousMethodExample : MonoBehaviour
{
    // �͸�޼��� or ����޼��� : �̸��� ���� �޼���

    /*
     *  - �͸�޼����� ����
     *  delegate(�Ű�����){
     *      ����...
     *  }
     */

    /*
     *  - ���ٽ��� ����
     *  - �⺻ ����
     *  (�Ű�����) => {
     *      ����...
     *  }
     * 
     * 
     *  - �Ű����� Ÿ�԰� �߰�ȣ�� return���� ���� ����
     * 
     * 
     */


    delegate int myDelegate(int a, int b);



    private void Start()
    {
        // �͸�޼���
        //myDelegate del = delegate (int a, int b)        // �ѹ��� �������� ���� �޼ҵ��� ���� �������� ���� �Ｎ���� ���� �� �ִ�.
        //{
        //    return a + b;
        //};

        // ���ٽ� 1
        //myDelegate del = (int a, int b) =>
        //{
        //    return a + b;
        //};


        // ���ٽ� 2
        myDelegate del = (a, b) => a + b;

        Debug.Log(del(2, 4));
    }

    int Add(int a, int b)
    {
        return a + b; 
    }
}
