using UnityEngine;
using System.Collections;


public class coroutineExample : MonoBehaviour
{
    // 일정 시간 후에 메서드가 실행 -> Invoke
    // 1. 메서드에 인수를 담을 수 없다.
    // 2. 일정 시간 후에 메서드를 실행 하는 것 말고 다른 기능은 없다.

    // -> 코루틴!

    /*
     *  - 코루틴의 구조
     *  IEnumerator 코루틴_이름(매개변수){
     *      yield return 문
     *  }
     */
    // * yeild return -> 호출자에게 제어권을 넘기는 역할

    private void Start()
    {
        StartCoroutine(First());
        Debug.Log("3");
    }

    IEnumerator First()
    {
        Debug.Log("1");
        yield return null;      // 다시 Start()로 제어가 넘어감 ..  불렀던 애한테 돌아감 .. 이후 다시 돌아옴
        StartCoroutine(Second()); 
    }
    IEnumerator Second()
    {
        Debug.Log("2");  
        yield return null;
    }
    IEnumerator Third()
    {
        yield return null;
    }

}
