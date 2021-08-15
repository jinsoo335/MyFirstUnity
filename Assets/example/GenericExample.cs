using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    // 제네릭 : 타입을 미리 정의하지 않고 타입을 사용할 때 정의하는 것
    // 형식 매개변수 (T) : 미리 타입을 정의하지 않고 T라고 타입을 가짜로 정의해 놓는 것


    void Start()
    {
        DataClass<int> dc = new DataClass<int>();
        dc.data = 1;
        dc.GetData();

        DataClass<float> dc2 = new DataClass<float>();
        dc2.data = 1.0f;
        dc2.GetData();
    }

    
}

class DataClass<T>
{
    public T data;

    public T GetData()
    {
        return data;
    }
}