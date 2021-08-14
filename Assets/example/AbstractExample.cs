using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    // 추상 클래스 / 추상 메서드 -> 부모클래스에서 정의한 메서드를 자식클래스에서 반드시 재정의하도록 강제할 때
    /* 추상 메서드는 반드시 추상클래스 내에 존재해야 한다.
     * 
     *  - 추상클래스
     *  abstract class 클래스_이름{
     *  
     *  }
     *  
     *  - 추상 메서드
     *  접근_제한자 abstract 반환_타입 메서드_이름(매개변수);
     *  
     *  - 자식클래스에서 재정의   override 필수
     *  접근_제한자 override 반환_타입 메서드_이름(매개변수){
     *      ... 구현
     *  }
     */

    private void Start()
    {
        Bird eagle = new Bird();
        Fish gold = new Fish();

        eagle.Move();
        gold.Move();
       
    }


}

abstract class Animal
{
    public abstract void Move();
    
}

class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Fly!");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Debug.Log("Swim!");
    }
}
