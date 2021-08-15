using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionExample : MonoBehaviour
{
    // * 배열의 비효율성
    // - 크기를 변경할 수 없다.
    // - 요소를 추가하거나 제거하기 불편하다.
    // -> Collections!

    // 1. ArrayList : 배열의 단점을 극복!
    // 2. Hashtable : 키와 값을 쌍으로 저장
    // 3. Queue : 계산대에 줄 서는 것 상상    FIFO(First - In - First - Out)
    // 4. Stack : 블록 쌓기 상상      LIFO(Last - In - First - Out)

    // * 컬렉션의 치명적인 단점!
    // -> 박싱, 언박싱 -> 성능 문제!     .. 시간이 되게 오래 걸린다.
    // 컬렉션들은 받는 인자들을 object 타입으로 받는다.
    // -> 제네릭 컬렉션을 사용하자!!!

    // * object
    // - 뭐든지 다 담을 수 있는 그릇

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

        myAL.RemoveAt(1);   // { 1 }  1번 인덱스를 제거

        // 2. Hashtable
        Hashtable myHT = new Hashtable();
        myHT.Add("첫번째", 1209);
        myHT.Add(3, "Hello");

        Debug.Log(myHT["첫번째"]);     // 1209
        Debug.Log(myHT[3]);     // Hello

        myHT.Remove(3);

        // 3. Queue
        Queue myQueue = new Queue();
        myQueue.Enqueue(3);     // { 3 } 
        myQueue.Enqueue(4);     // { 3, 4 } 
        myQueue.Enqueue(5);     // { 3, 4, 5 } 

        Debug.Log(myQueue.Peek());  // 3 출력 { 3, 4, 5 }     출력 해도 값은 변하지 않음

        Debug.Log(myQueue.Dequeue());      // 3 출력   { 4, 5 }    출력과 동시에 삭제
        Debug.Log(myQueue.Dequeue());      // 4 출력   { 5 }

        // 4. Stack
        Stack myStack = new Stack();
        myStack.Push("a");  // { "a" }
        myStack.Push("b");  // { "a", "b" }
        myStack.Push("c");  // { "a", "b", "c" }

        Debug.Log(myStack.Peek());  // 3 출력 { 3, 4, 5 }

        Debug.Log(myStack.Pop());   // c 출력 { "a", "b" }
        Debug.Log(myStack.Pop());   // b 출력 { "a" }


        // * object type
        object number = 1;
        object str = "asldf";
        
        int num = 3;
        object a = num;     // 암시적 형변환 -> 박싱

        object b = 5;
        int num2 = (int)b;      // 명시적 형변환 -> 언박싱

    }

}
