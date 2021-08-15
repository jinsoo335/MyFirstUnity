using UnityEngine;
using System;

public class ActionFuncExample : MonoBehaviour
{
    // * Action�� Func
    // - �̸� ���ǵ� ��������Ʈ Ÿ��
    // - Action : ��ȯŸ���� ���� ��������Ʈ Ÿ��
    // - Func : ��ȯŸ���� �ִ� ��������Ʈ Ÿ��



    private void Start()
    {
        //Action<string> del = PrintMessage;
        //Action act = PrintHello;
        //Func<int, int, int> act2 = Mult;        // ���� �ΰ� int�� �Ű����� Ÿ��, ���� int�� ��ȯŸ��

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
