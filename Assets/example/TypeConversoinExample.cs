using UnityEngine;

public class TypeConversoinExample : MonoBehaviour
{
    // * ����ȯ ����
    // 1. �Ͻ��� ����ȯ : ���� �׸� -> ū �׸�,, int -> long
    // 2. ����� ����ȯ : ū �׸� -> ���� �׸�    ���� �տ� '(type��)'

    // * Ŭ����
    // - �Ϲ����� Ÿ�� : Human
    // - Ư���� Ÿ��: Adult, Baby    �Ļ�..

    // * Ŭ���������� ����ȯ
    // 1. �Ͻ��� ����ȯ : Ư���� Ÿ�� -> �Ϲ��� Ÿ��
    // 2. ����� ����ȯ : �Ϲ��� Ÿ�� -> Ư���� Ÿ�� (��ü�� Ư���� Ÿ���� ��쿡�� ����)

    // as �� is
    // as : ������ �߻���Ű�� �ʰ� ����ȯ�� �õ�
    // is : ����ȯ�� �������� üũ


    void Start()
    {
        // �Ͻ��� ����ȯ
        Adult jinsoo = new Adult();
        Human jinsu = jinsoo;


        // ����� ����ȯ�� �Ұ����� ��� * ��ü�� �Ϲ��� Ÿ��
        Human human = new Human();
        //Adult Lina = (Adult)human;

        // ����� ����ȯ�� ������ ���  * ��ü�� Ư���� Ÿ��
        Human adult = new Adult();
        Adult Jina = (Adult)adult;

        Adult sina = adult as Adult;
        Debug.Log(sina);
        if (sina == null)
        {
            Debug.Log("����!");
        }
        else
        {
            Debug.Log("����~!");
        }

        // is�� ����
        Debug.Log(human is Adult);  // false    ����ȯ�� ���������� ���� true, false �� ��ȯ
        Debug.Log(adult is Human);  // true     Ư���� Ÿ���� �Ϲ��� Ÿ������ �Ͻ��� ����ȯ�� �����ϱ� ������
        
        if (human is Adult)     //  ����ȯ�� ��������� �� ��� ������ �� �� �����Ƿ� is �� ���� �ѹ� Ȯ�� �� ��
        {
            Adult newAdult = (Adult)human;
        }

    }
}
