using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionExample : MonoBehaviour
{
    // * �迭�� ��ȿ����
    // - ũ�⸦ ������ �� ����.
    // - ��Ҹ� �߰��ϰų� �����ϱ� �����ϴ�.
    // -> Collections!

    // 1. ArrayList : �迭�� ������ �غ�!
    // 2. Hashtable : Ű�� ���� ������ ����
    // 3. Queue : ���뿡 �� ���� �� ���    FIFO(First - In - First - Out)
    // 4. Stack : ��� �ױ� ���      LIFO(Last - In - First - Out)

    // * �÷����� ġ������ ����!
    // -> �ڽ�, ��ڽ� -> ���� ����!     .. �ð��� �ǰ� ���� �ɸ���.
    // �÷��ǵ��� �޴� ���ڵ��� object Ÿ������ �޴´�.
    // -> ���׸� �÷����� �������!!!

    // * object
    // - ������ �� ���� �� �ִ� �׸�

    void Start()
    {
        // 1. ArrayList
        ArrayList myAL = new ArrayList();
        myAL.Add(1);    // { 1 }
        myAL.Add(39);    // { 1, 39 }
        myAL.Add("hello");    // { 1, 39, hello }

        Debug.Log(myAL.Count);
        Debug.Log(myAL[1]); // 39

        myAL.Remove(39);

        Debug.Log(myAL.Count);
        Debug.Log(myAL[1]); // hello

        myAL.RemoveAt(1);   // { 1 }  1�� �ε����� ����

        // 2. Hashtable
        Hashtable myHT = new Hashtable();
        myHT.Add("ù��°", 1209);
        myHT.Add(3, "Hello");

        Debug.Log(myHT["ù��°"]);     // 1209
        Debug.Log(myHT[3]);     // Hello

        myHT.Remove(3);

        // 3. Queue
        Queue myQueue = new Queue();
        myQueue.Enqueue(3);     // { 3 } 
        myQueue.Enqueue(4);     // { 3, 4 } 
        myQueue.Enqueue(5);     // { 3, 4, 5 } 

        Debug.Log(myQueue.Peek());  // 3 ��� { 3, 4, 5 }     ��� �ص� ���� ������ ����

        Debug.Log(myQueue.Dequeue());      // 3 ���   { 4, 5 }    ��°� ���ÿ� ����
        Debug.Log(myQueue.Dequeue());      // 4 ���   { 5 }

        // 4. Stack
        Stack myStack = new Stack();
        myStack.Push("a");  // { "a" }
        myStack.Push("b");  // { "a", "b" }
        myStack.Push("c");  // { "a", "b", "c" }

        Debug.Log(myStack.Peek());  // 3 ��� { 3, 4, 5 }

        Debug.Log(myStack.Pop());   // c ��� { "a", "b" }
        Debug.Log(myStack.Pop());   // b ��� { "a" }


        // * object type
        object number = 1;
        object str = "asldf";
        
        int num = 3;
        object a = num;     // �Ͻ��� ����ȯ -> �ڽ�

        object b = 5;
        int num2 = (int)b;      // ����� ����ȯ -> ��ڽ�

    }

}
