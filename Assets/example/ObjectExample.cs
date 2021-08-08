using UnityEngine;

public class ObjectExample : MonoBehaviour
{
    // 인스턴스화 : 클래스를 이용해 객체를 생성
    // new 클래스_이름();

    void Start()
    {
        Human john = new Human();
        john.Name = "john";
        john.Age = 24;
        john.Height = 175;

        john.Eat();

    }


}
