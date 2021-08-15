using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // static : 객체와 상관없이 타입에 종속적인 맴버 -> 정적 맴버

    void Start()
    {
        // ExampleClass의 number가 일반 멤버일 경우

        //ExampleClass ex1 = new ExampleClass();
        //ExampleClass ex2 = new ExampleClass();

        //ex1.number = 1;
        //ex2.number = 2;

        //Debug.Log(ex1.number);      // 1
        //Debug.Log(ex2.number);      // 2


        // number가 static 멤버일 경우
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