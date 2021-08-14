using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
   /* 
    *  - interface
    *  interface 인터페이스_이름 {
    *       ... 구현
    *  }
    *  
    */
   // 인터페이스는 반드시 추상 멤버만 구현해야 함. -> 장착받는 클래스는 이를 다 구현해야함
   // 인터페이스는 abstract를 쓰지 않음 .. 모두가 추상 멤버
   // ** 인터페이스는 다중 장착이 가능하다! **
}


interface ISword
{
    float Damage { get; set; }  // 추상 속성을 만들 수 있다.
    void Attack();
}

interface IShield
{
    float DefensivePower { get; set; }  // 추상 속성을 만들 수 있다.
    void Defend();
}

class Knight : ISword, IShield   // 추상 멤버를 구현해야함
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