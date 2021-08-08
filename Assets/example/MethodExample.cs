using UnityEngine;

public class MethodExample : MonoBehaviour
{
    /*
      - 메서드의 기본 구조
      접근_제한자 반환_타입 메서드_이름(매개변수){
        .. 실행할 코드
      }
     */

    // 1. 실생활에서 자주 쓰이는 메서드 : Half -> 입력값을 반으로 나누어 반환해주는 메서드
    // 2. 반환값이 없는 메서드 : PrintNumber
    // 3. 매개변수가 없는 메서드 : GetTen
    // 4. 매개변수가 여러 개인 메서드 : Add
    // 5. 반환값과 메개변수가 없는 메서드 : PrintHello

    float Half(float num)
    {
        return num / 2;
    }

    void PrintNumber(int num)
    {
        Debug.Log(num);
    }

    int GetTen()
    {
        return 10;
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    void PrintHello()
    {
        Debug.Log("Hello");
    }

    void Start()
    {
        //float result = Half(10);
        //Debug.Log(result);

        GetTen();  // 10
        Add(1, 3); // 4 

        PrintHello(); // console -> "Hello"

    }


}
