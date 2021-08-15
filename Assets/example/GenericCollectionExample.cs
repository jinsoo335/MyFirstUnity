using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCollectionExample : MonoBehaviour
{
    // 1. ArraryList => List<T>
    // 2. HashTable => Dictionary<TKey, TValue>
    // 3. Queue => Queue<T>
    // 4. Stack => Stack<T>
    


    void Start()
    {
        // 1. List
        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Remove(1);
        Debug.Log(myList[0]);   // 2


        // 2. Dictionary<Tkey, TValue>
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict.Add(1, "hello");
        myDict.Add(16, "hi");
        myDict.Remove(16);
        Debug.Log(myDict[1]);   // "hello"
;

        // 3. Queue<T>
        Queue<float> myQueue = new Queue<float>();
        myQueue.Enqueue(1);     // float 형이 int 형보다 크기 때문에 암시적 형변환이 일어난다.
        myQueue.Enqueue(3.0f);
        myQueue.Enqueue(2.0f);
        myQueue.Peek();         // 1.0f
        myQueue.Dequeue();      // 1.0f


        // 4. Stack<T>
        Stack<char> myStack = new Stack<char>();
        myStack.Push('a');
        myStack.Push('b');
        myStack.Push('c');
        myStack.Peek();     // 'c'
        myStack.Pop();      // 'c'

    }



   
}
