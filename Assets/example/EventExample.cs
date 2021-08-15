using UnityEngine;

public class EventExample : MonoBehaviour
{
    // event : 델리게이트의 한정자
    // - event를 선언한 클래스에서만 사용 가능함


    void Start()
    {
        Publisher pub = new Publisher();
        Subsriber sub = new Subsriber();

        pub.RunEvent();     // do something
    }
    

}

delegate void myEventHandler();

class Publisher
{
    public static event myEventHandler myEvent;


    public void RunEvent()
    {
        if (myEvent != null)
        {
            myEvent();
        }
    }
}

class Subsriber
{
    public Subsriber()
    {
        Publisher.myEvent += DoSomething;
    }
    public void DoSomething()
    {
        Debug.Log("do something");
    }
}
