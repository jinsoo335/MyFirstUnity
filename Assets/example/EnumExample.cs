using UnityEngine;

public class EnumExample : MonoBehaviour
{
    // 열거형 : 숫자에 이름을 붙인 것.
    /*
     *  - 열거형의 구조
     *  enum 열거형_이름 {
     *      요소1, 요소2, 요소3 ...
     *  }
     */

    string[] names = { "john", "chulsoo", "bbobbi", "noorungi" };

    private void Start()
    {
        //Debug.Log((int)Days.Mon);
        //Debug.Log((int)Days.Sat);

        Debug.Log(names[(int)Names.bbobbi]);        // 가독성이 좋다.
        Debug.Log(names[3]);
    }
    

}

enum Days
{
    Mon, Tue, Wed, Thu = 7, Fri, Sat, Sun
}

enum Names      // enum에서 값을 지움으로서 접근할 수 있는 값을 제어하는 효과를 낼 수 있다.
{ 
    john, bbobbi = 2, noorungi      // 이때 지웠다면 배열과 비교하여 index 값이 같도록 enum 값을 수정 해줘야 한다
}