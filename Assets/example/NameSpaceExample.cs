using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSpaceExample : MonoBehaviour       // unityEngine�� �ִ� MonoBehaviour Ŭ����.. -> UnityEngine.MonoBehavour
{
    // ���ӽ����̽� : Ŭ�������� ����.
    // ���ӽ����̽� �� Ŭ������ �����ϴ� ���
    // 1. using     --> ���� ����ϴ� Ŭ������ ����
    // 2. ���ӽ����̽�_�̸�.Ŭ����_�̸�

    private void Start()
    {
        examples.A a = new examples.A();
    }

}

namespace examples
{
    class A
    {

    }

    class B
    {

    }
}