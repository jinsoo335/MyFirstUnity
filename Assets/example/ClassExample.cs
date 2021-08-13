using UnityEngine;

public class ClassExample : MonoBehaviour
{
    // Ŭ���� -> ��ü������ 4���� Ư�� : �߻�ȭ, ĸ��ȭ, ���, ������
    // �߻�ȭ : ���� ������ �繰, ������ �Ӽ��� ������ �����Ͽ� �𵨸��ϴ� ����
    // ĸ��ȭ (encapsulation)
    // * �ʿ��� ������ �ѵ� ������.
    // * �ܺο� ������ �Ͱ� �������� ���� ���� �����Ѵ�.

    /*  
        ������    // class
        - �̸� :
        - ���� :
        - �� :
        - Ű :
        - �Դ�. �ȴ�. �ڴ�.

        1. �ǻ�   //object
        - �̸� : �ǻ�
        - ���� : 3��
        - �� : ���
        - Ű : 40cm
        - �Դ�. �ȴ�. �ڴ�.

        2. ����   // object
        - �̸� : ����
        - ���� : 5��
        - �� : ����
        - Ű : 30cm
        - �Դ�. �ȴ�. �ڴ�.
     */
    /* 
        Ŭ������ �⺻ ����
        class Ŭ����_�̸�{
      
        }
     */

}

/*
 *  * Ŭ������ ���
 *  ����� �Ӽ� : �̸�, Ű, ����       -> �ʵ� (����)
 *  ����� ���� : �Դ�. �Ŵ�. �ڴ�     -> �޼���
 *  
 *  - �޼����� �⺻ ����
 *  ����_������ ��ȯ_Ÿ�� �޼���_�̸�(�Ű�����){
 *      .. ������ �ڵ�
 *  }
 *  
 *  - �Լ��� �޼���
 *      -y = f(x)
 *      -> x��� �Է°��� f�� �־��� ��  y��� ��°��� ����.
 *      -> �޼��� : �Ű������� �Է°��� �������� �� ���� �ڵ带 �����ϰ� ��ȯ���� ��ȯ�Ѵ�.
 */




class Human
{
    protected string name;  
    protected float height;
    protected int age;

    public Human()
    {

    }

    public string Name          //  �Ӽ�
    {
        get
        {
            Debug.Log("�̸��� �����ߴ�!");
            return name;
        }
        set
        {
            Debug.Log("�̸��� �����ߴ�!");
            name = value;
        }
        
    }
    public float Height          //  �Ӽ�
    {
        get 
        { 
            return height;
        }
        set
        {
            height = value;
        }

    }
    public int Age          //  �Ӽ�
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }

    }

    public string GetName()
    {
        Debug.Log("�̸��� �����ߴ�!");
        return name;
    }

    public void SetName(string value)
    {
        Debug.Log("�̸��� �����ߴ�!");
        name = value;
    }

   

    public Human(string name, float height, int age)  
    {
        this.name = name;
        this.height = height;
        this.age = age;
    }

    public void Eat()
    {
        Debug.Log("eat!");
    }
    public void Eat(string something)
    {
        Debug.Log("eat!" + something);
    }

    public virtual void Walk()
    {
        Debug.Log("walk!");
    }
    public void Sleep()
    {
        Debug.Log("sleep!");
    }
}