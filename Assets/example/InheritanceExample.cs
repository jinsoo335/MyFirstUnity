using UnityEngine;

public class InheritanceExample : MonoBehaviour
{

    // * 상속 : 부모 클래스의 멤버를 자식 클래스가 물려받는 것
    // -> 클래스명 뒤에 콜론(:)을 붙인 후 상속할 클래스 이름을 써준다.

    // * 용어 정리
    // 1. 베이스(base) 클래스 / 파생(derived) 클래스
    // 2. 부모(parent) 클래스 / 자식(child) 클래스

    // * 자식 클래스는 여러 부모 클래스를 가질 수 없다.
    // * 부모 클래스는 여러 자식 클래스를 가질 수 있다.

    //  * protected
    //  -> 자식 클래스에게만 멤버를 공개하는 접근제한자
    //  * this / base
    //  this : 현재 객체를 가리키는 키워드
    //  base : 부모 클래스를 가리키는 키워드

    // * 메서드 오버라이드 (Override)
    // - 부모 클래스의 메서드를 자식 클래스에서 '재정의'하는 것
    /*
     *      메서드 오버라이들의 기본 구조 (virtual override)
     *      - 부모 클래스의 메서드
     *      접근_제한자 virtual 반환_타입 매서드_이름(매개변수){
     *      }
     *      - 부모 클래스의 메서드
     *      접근_제한자 override 반환_타입 매서드_이름(매개변수){
     *      }
     *      
     */

    // * 오버라이드의 3가지 경우
    // 1. 부모 타입 객체를 부모 타입 변수에 대입
    // 2. 자식 타입 객체를 부모 타입 변수에 대입
    // 3. 자식 타입 객체를 자식 타입 변수에 대입


    void Start()
    {
        Adult tom = new Adult("tom", 175, 40);    // 기본 생성자가 아닌 다른 생성자를 사용하려면 상속 받은 클래스에서 생성자를 만들어야함
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
    public int Age; // 부모와 같은 이름의 변수를 설정하면 단순 호출 시 자식에서는 자식에서 만든 변수 값만 읽는다.  --> 이럴 때 base를 사용한다.

    public Adult(string name, float height, int age) : base(name, height, age)    // 새로운 생성자를 만들었다면 기본 생성자는 사라진다. 쓰고 싶다면 새로 만들 것
    {                                                                             // base 키워드를 통해 부모 클래스의 생성자를 호출한다.
        //Name = _name;
        //Height = _height;
        //Age = _age;
    }

    public Adult()
    {
    }

    public void PrintName()
    {
        Debug.Log(name);    // 속성변수가 아닌 private 접근제한자의 name을 바로 쓸 수는 없다.
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