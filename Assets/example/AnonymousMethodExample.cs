using UnityEngine;

public class AnonymousMethodExample : MonoBehaviour
{
    // 익명메서드 or 무명메서드 : 이름이 없는 메서드

    /*
     *  - 익명메서드의 구조
     *  delegate(매개변수){
     *      내용...
     *  }
     */

    /*
     *  - 람다식의 구조
     *  - 기본 구조
     *  (매개변수) => {
     *      내용...
     *  }
     * 
     * 
     *  - 매개변수 타입과 중괄호와 return까지 생략 가능
     * 
     * 
     */


    delegate int myDelegate(int a, int b);



    private void Start()
    {
        // 익명메서드
        //myDelegate del = delegate (int a, int b)        // 한번만 전달히기 위한 메소드라면 따로 선언하지 말고 즉석에서 만들 수 있다.
        //{
        //    return a + b;
        //};

        // 람다식 1
        //myDelegate del = (int a, int b) =>
        //{
        //    return a + b;
        //};


        // 람다식 2
        myDelegate del = (a, b) => a + b;

        Debug.Log(del(2, 4));
    }

    int Add(int a, int b)
    {
        return a + b; 
    }
}
