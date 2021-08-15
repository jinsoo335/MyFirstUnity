using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // * ��������Ʈ(delegate) : �޼��带 ��� Ÿ��
    /*
     *  - ��������Ʈ�� �⺻ ����
     *  delegate ��ȯ_Ÿ�� ��������Ʈ_�̸�(�Ű�����);      ���� ���� �޼����� ��ȯ Ÿ��,, ���� ���� �޼����� �Ű�����
     */

    // * ����
    // 1. ��������Ʈ Ÿ�� ����
    // 2. ��������Ʈ ���� ����
    // 3. ��������Ʈ ������ �޼��� ���

    // * ��Ƽĳ��Ʈ
    // - +=, -= �����ڸ� �̿��ؼ� �޼��带 �߰��ϰų� ������ �� �ִ�.

    // *** �ݹ�
    // - ȣ����(caller), ��ȣ����(callee)
    // - �ݹ� : ��ȣ���ڰ� ȣ������ �޼��带 �ٽ� ȣ���ϴ� ��


    delegate void ExampleDelegate();

    void Hello()
    {
        Debug.Log("hello");
    }

    void Bye()
    {
        Debug.Log("bye");
    }


    void Start()
    {
        //ExampleDelegate ed = new ExampleDelegate(Hello);
        //ExampleDelegate ed = Hello; // �� ǥ���� �����
        //ed += Bye;
        //ed();

        Mom mom = new Mom();
        Son son = new Son();

        mom.GetSonToStudy(son);
    }

    
}


delegate void StudyDelegate();

class Mom
{
    StudyDelegate sd;
    public void GetSonToStudy(Son son)
    {
        sd += FinishStudy;
        son.Study(sd);
    }

    public void FinishStudy()
    {
        Debug.Log("Study done!");
    }
}

class Son
{
    public void Study(StudyDelegate sd)
    {
        Debug.Log("studying....");
        sd();
    }

    
}