using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    // ���׸� : Ÿ���� �̸� �������� �ʰ� Ÿ���� ����� �� �����ϴ� ��
    // ���� �Ű����� (T) : �̸� Ÿ���� �������� �ʰ� T��� Ÿ���� ��¥�� ������ ���� ��


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