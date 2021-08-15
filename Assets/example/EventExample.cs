using UnityEngine;

public class EventExample : MonoBehaviour
{
    // event : ��������Ʈ�� ������
    // - event�� ������ Ŭ���������� ��� ������


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
