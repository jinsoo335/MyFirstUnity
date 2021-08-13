using UnityEngine;

public class TypeConversoinExample : MonoBehaviour
{
    // * 형변환 복습
    // 1. 암시적 형변환 : 작은 그릇 -> 큰 그릇,, int -> long
    // 2. 명시적 형변환 : 큰 그릇 -> 작은 그릇    변수 앞에 '(type명)'

    // * 클래스
    // - 일반적인 타입 : Human
    // - 특수한 타입: Adult, Baby    파생..

    // * 클래스에서의 형변환
    // 1. 암시적 형변환 : 특수한 타입 -> 일반적 타입
    // 2. 명시적 형변환 : 일반적 타입 -> 특수한 타입 (객체가 특수한 타입인 경우에만 가능)

    // as 와 is
    // as : 에러를 발생시키지 않고 형변환을 시도
    // is : 형변환이 가능한지 체크


    void Start()
    {
        // 암시적 형변환
        Adult jinsoo = new Adult();
        Human jinsu = jinsoo;


        // 명시적 형변환이 불가능한 경우 * 객체가 일반적 타입
        Human human = new Human();
        //Adult Lina = (Adult)human;

        // 명시적 형변환이 가능한 경우  * 객체가 특수한 타입
        Human adult = new Adult();
        Adult Jina = (Adult)adult;

        Adult sina = adult as Adult;
        Debug.Log(sina);
        if (sina == null)
        {
            Debug.Log("실패!");
        }
        else
        {
            Debug.Log("성공~!");
        }

        // is의 사용법
        Debug.Log(human is Adult);  // false    형변환이 가능한지에 대해 true, false 로 반환
        Debug.Log(adult is Human);  // true     특수한 타입은 일반적 타입으로 암시적 형변환이 가능하기 때문에
        
        if (human is Adult)     //  형변환을 명시적으로 할 경우 에러가 날 수 있으므로 is 를 통해 한번 확인 할 것
        {
            Adult newAdult = (Adult)human;
        }

    }
}
