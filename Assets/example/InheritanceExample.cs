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

    void Start()
    {
        Adult tom = new Adult("tom", 175, 20);    // 기본 생성자가 아닌 다른 생성자를 사용하려면 상속 받은 클래스에서 생성자를 만들어야함
        tom.Age = 20;
        tom.Eat();

        Baby b = new Baby();
        b.Eat();
        b.Height = 90;

    }

}

class Adult : Human
{
    public Adult(string _name, float _height, int _age)  // 새로운 생성자를 만들었다면 기본 생성자는 사라진다. 쓰고 싶다면 새로 만들 것
    {
        
    }
}

class Baby : Human
{

}