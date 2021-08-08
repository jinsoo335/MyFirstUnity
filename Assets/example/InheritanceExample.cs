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

    void Start()
    {
        Adult tom = new Adult("tom", 175, 20);    // �⺻ �����ڰ� �ƴ� �ٸ� �����ڸ� ����Ϸ��� ��� ���� Ŭ�������� �����ڸ� ��������
        tom.Age = 20;
        tom.Eat();

        Baby b = new Baby();
        b.Eat();
        b.Height = 90;

    }

}

class Adult : Human
{
    public Adult(string _name, float _height, int _age)  // ���ο� �����ڸ� ������ٸ� �⺻ �����ڴ� �������. ���� �ʹٸ� ���� ���� ��
    {
        
    }
}

class Baby : Human
{

}