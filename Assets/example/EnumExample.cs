using UnityEngine;

public class EnumExample : MonoBehaviour
{
    // ������ : ���ڿ� �̸��� ���� ��.
    /*
     *  - �������� ����
     *  enum ������_�̸� {
     *      ���1, ���2, ���3 ...
     *  }
     */

    string[] names = { "john", "chulsoo", "bbobbi", "noorungi" };

    private void Start()
    {
        //Debug.Log((int)Days.Mon);
        //Debug.Log((int)Days.Sat);

        Debug.Log(names[(int)Names.bbobbi]);        // �������� ����.
        Debug.Log(names[3]);
    }
    

}

enum Days
{
    Mon, Tue, Wed, Thu = 7, Fri, Sat, Sun
}

enum Names      // enum���� ���� �������μ� ������ �� �ִ� ���� �����ϴ� ȿ���� �� �� �ִ�.
{ 
    john, bbobbi = 2, noorungi      // �̶� �����ٸ� �迭�� ���Ͽ� index ���� ������ enum ���� ���� ����� �Ѵ�
}