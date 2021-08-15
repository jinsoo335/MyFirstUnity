using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // static : ��ü�� ������� Ÿ�Կ� �������� �ɹ� -> ���� �ɹ�

    void Start()
    {
        // ExampleClass�� number�� �Ϲ� ����� ���

        //ExampleClass ex1 = new ExampleClass();
        //ExampleClass ex2 = new ExampleClass();

        //ex1.number = 1;
        //ex2.number = 2;

        //Debug.Log(ex1.number);      // 1
        //Debug.Log(ex2.number);      // 2


        // number�� static ����� ���
        ExampleClass.number = 1;
        Debug.Log(ExampleClass.number);

        Member chulsoo = new Member(17, "chulsoo");
        Member jini = new Member(17, "jini");

        Debug.Log(Member.numOfMembers);
    }

}

class ExampleClass
{
    public static int number;
}

class Member
{
    public int age;
    public string name;
    public static int numOfMembers;

    public Member(int age, string name)
    {
        this.age = age;
        this.name = name;
        numOfMembers++;
    }
}