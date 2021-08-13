using UnityEngine;

public class InheritanceExample : MonoBehaviour
{

    // * ��� : �θ� Ŭ������ ����� �ڽ� Ŭ������ �����޴� ��
    // -> Ŭ������ �ڿ� �ݷ�(:)�� ���� �� ����� Ŭ���� �̸��� ���ش�.

    // * ��� ����
    // 1. ���̽�(base) Ŭ���� / �Ļ�(derived) Ŭ����
    // 2. �θ�(parent) Ŭ���� / �ڽ�(child) Ŭ����

    // * �ڽ� Ŭ������ ���� �θ� Ŭ������ ���� �� ����.
    // * �θ� Ŭ������ ���� �ڽ� Ŭ������ ���� �� �ִ�.

    //  * protected
    //  -> �ڽ� Ŭ�������Ը� ����� �����ϴ� ����������
    //  * this / base
    //  this : ���� ��ü�� ����Ű�� Ű����
    //  base : �θ� Ŭ������ ����Ű�� Ű����

    // * �޼��� �������̵� (Override)
    // - �θ� Ŭ������ �޼��带 �ڽ� Ŭ�������� '������'�ϴ� ��
    /*
     *      �޼��� �������̵��� �⺻ ���� (virtual override)
     *      - �θ� Ŭ������ �޼���
     *      ����_������ virtual ��ȯ_Ÿ�� �ż���_�̸�(�Ű�����){
     *      }
     *      - �θ� Ŭ������ �޼���
     *      ����_������ override ��ȯ_Ÿ�� �ż���_�̸�(�Ű�����){
     *      }
     *      
     */

    // * �������̵��� 3���� ���
    // 1. �θ� Ÿ�� ��ü�� �θ� Ÿ�� ������ ����
    // 2. �ڽ� Ÿ�� ��ü�� �θ� Ÿ�� ������ ����
    // 3. �ڽ� Ÿ�� ��ü�� �ڽ� Ÿ�� ������ ����


    void Start()
    {
        Adult tom = new Adult("tom", 175, 40);    // �⺻ �����ڰ� �ƴ� �ٸ� �����ڸ� ����Ϸ��� ��� ���� Ŭ�������� �����ڸ� ��������
        Debug.Log(tom.GetBaseAge());

        Human john1 = new Human();
        Human john2 = new Baby();
        Baby john3 = new Baby();

        john1.Walk();
        john2.Walk();
        john3.Walk();


    }
}

class Adult : Human
{
    public int Age; // �θ�� ���� �̸��� ������ �����ϸ� �ܼ� ȣ�� �� �ڽĿ����� �ڽĿ��� ���� ���� ���� �д´�.  --> �̷� �� base�� ����Ѵ�.

    public Adult(string name, float height, int age) : base(name, height, age)    // ���ο� �����ڸ� ������ٸ� �⺻ �����ڴ� �������. ���� �ʹٸ� ���� ���� ��
    {                                                                             // base Ű���带 ���� �θ� Ŭ������ �����ڸ� ȣ���Ѵ�.
        //Name = _name;
        //Height = _height;
        //Age = _age;
    }

    public Adult()
    {
    }

    public void PrintName()
    {
        Debug.Log(name);    // �Ӽ������� �ƴ� private ������������ name�� �ٷ� �� ���� ����.
    }

    public int GetBaseAge()
    {
        return base.Age;
    }


}

class Baby : Human
{
    public override void Walk()
    {
        Debug.Log("crawl!");
    }
}