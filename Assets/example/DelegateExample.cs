using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // * 델리게이트(delegate) : 메서드를 담는 타입
    /*
     *  - 델리게이트의 기본 구조
     *  delegate 반환_타입 델리게이트_이름(매개변수);      내가 담을 메서드의 반환 타입,, 내가 담을 메서드의 매개변수
     */

    // * 과정
    // 1. 델리게이트 타입 선언
    // 2. 델리게이트 변수 선언
    // 3. 델리게이트 변수에 메서드 담기

    // * 멀티캐스트
    // - +=, -= 연산자를 이용해서 메서드를 추가하거나 제거할 수 있다.

    // *** 콜백
    // - 호출자(caller), 피호출자(callee)
    // - 콜백 : 피호출자가 호출자의 메서드를 다시 호출하는 것


    delegate void ExampleDelegate();

    void Hello()
    {
        Debug.Log("hello");
    }

    void Bye()
    {
        Debug.Log("bye");
    }


    void Start()
    {
        //ExampleDelegate ed = new ExampleDelegate(Hello);
        //ExampleDelegate ed = Hello; // 위 표현의 축약형
        //ed += Bye;
        //ed();

        Mom mom = new Mom();
        Son son = new Son();

        mom.GetSonToStudy(son);
    }

    
}


delegate void StudyDelegate();

class Mom
{
    StudyDelegate sd;
    public void GetSonToStudy(Son son)
    {
        sd += FinishStudy;
        son.Study(sd);
    }

    public void FinishStudy()
    {
        Debug.Log("Study done!");
    }
}

class Son
{
    public void Study(StudyDelegate sd)
    {
        Debug.Log("studying....");
        sd();
    }

    
}