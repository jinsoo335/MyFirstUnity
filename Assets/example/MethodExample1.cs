using UnityEngine;

public class MethodExample1 : MonoBehaviour
{
    // 메서드 오버로드 : 메서드의 식별자는 같지만 매개변수가 다른 여러 매서드를 정의하는 것

    private void Start()
    {
        Debug.Log(Add(1, 2)); // 3
        Debug.Log(Add(1.1f, 22.2f));
        
    }




    int Add(int a, int b)
    {
        return (a + b);
    }
    float Add(float a, float b)
    {
        return (a + b);
    }

}
