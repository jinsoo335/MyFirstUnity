using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
   /* 
    *  - interface
    *  interface �������̽�_�̸� {
    *       ... ����
    *  }
    *  
    */
   // �������̽��� �ݵ�� �߻� ����� �����ؾ� ��. -> �����޴� Ŭ������ �̸� �� �����ؾ���
   // �������̽��� abstract�� ���� ���� .. ��ΰ� �߻� ���
   // ** �������̽��� ���� ������ �����ϴ�! **
}


interface ISword
{
    float Damage { get; set; }  // �߻� �Ӽ��� ���� �� �ִ�.
    void Attack();
}

interface IShield
{
    float DefensivePower { get; set; }  // �߻� �Ӽ��� ���� �� �ִ�.
    void Defend();
}

class Knight : ISword, IShield   // �߻� ����� �����ؾ���
{
    public float Damage { get; set;  }
    public float DefensivePower { get; set;  }
    public void Attack()
    {

    }
    public void Defend()
    {

    }
}