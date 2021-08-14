using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSpaceExample : MonoBehaviour       // unityEngine에 있는 MonoBehaviour 클래스.. -> UnityEngine.MonoBehavour
{
    // 네임스페이스 : 클래스들의 묶음.
    // 네임스페이스 내 클래스에 접근하는 방법
    // 1. using     --> 자주 사용하는 클래스는 쓰자
    // 2. 네임스페이스_이름.클래스_이름

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