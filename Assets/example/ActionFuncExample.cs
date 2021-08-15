using UnityEngine;
using System;

public class ActionFuncExample : MonoBehaviour
{
    // * Action과 Func
    // - 미리 정의된 델리게이트 타입
    // - Action : 반환타입이 없는 델리게이트 타입
    // - Func : 반환타입이 있는 델리게이트 타입



    private void Start()
    {
        //Action<string> del = PrintMessage;
        //Action act = PrintHello;
        //Func<int, int, int> act2 = Mult;        // 앞의 두개 int는 매개변수 타입, 뒤의 int는 반환타입

        //del("Hi!");
        //act();
        //Debug.Log(act2(7, 3));    // 21

        Func<int, int, string> func = (a, b) => (a * b).ToString();
        Debug.Log(func(3, 7));  // 21

    }

    void PrintMessage(string message)
    {
        Debug.Log(message);
    }

    void PrintHello()
    {
        Debug.Log("Hello");

    }

    int Mult(int a, int b)
    {
        return a * b;
    }


}
