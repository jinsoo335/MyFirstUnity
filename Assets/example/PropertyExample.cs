using UnityEngine;

public class PropertyExample : MonoBehaviour
{

    // 속성 : 어떤 필드의 값에 접근하거나 수정하는 역할을 하는 멤버
    /*
     *  - 속성의 기본 구조
     *  접근_제한자 자료형 속성_이름{
     *      get { return 필드_이름; }
     *      set { 필드_이름 = value; }
     *  }
     *  
     *  - get, set => 접근자(accessor)
     *      - get 접근자 : 해당필드의 값에 접근하는 역할
     *      - set 접근자 : 해당필드의 값을 수정하는 역할
     */


    void Start()
    {
        Human chulsoo = new Human();
        chulsoo.Name = "yeonghee";
        Debug.Log(chulsoo.Name);
        chulsoo.SetName("bbobi");
        Debug.Log(chulsoo.GetName());

    }
}
