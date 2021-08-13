using UnityEngine;

public class ClassExample : MonoBehaviour
{
    // 클래스 -> 객체지향의 4가지 특성 : 추상화, 캡슐화, 상속, 다형성
    // 추상화 : 현실 세계의 사물, 개념의 속성과 행위를 추출하여 모델링하는 과정
    // 캡슐화 (encapsulation)
    // * 필요한 정보를 한데 모은다.
    // * 외부에 공개할 것과 공개하지 않을 것을 구분한다.

    /*  
        강아지    // class
        - 이름 :
        - 나이 :
        - 색 :
        - 키 :
        - 먹다. 걷다. 자다.

        1. 뽀삐   //object
        - 이름 : 뽀삐
        - 나이 : 3살
        - 색 : 흰색
        - 키 : 40cm
        - 먹다. 걷다. 자다.

        2. 초코   // object
        - 이름 : 초코
        - 나이 : 5살
        - 색 : 갈색
        - 키 : 30cm
        - 먹다. 걷다. 자다.
     */
    /* 
        클래스의 기본 구조
        class 클래스_이름{
      
        }
     */

}

/*
 *  * 클래스의 멤버
 *  사람의 속성 : 이름, 키, 나이       -> 필드 (변수)
 *  사람의 행휘 : 먹다. 거다. 자다     -> 메서드
 *  
 *  - 메서드의 기본 구조
 *  접근_제한자 반환_타입 메서드_이름(매개변수){
 *      .. 실행할 코드
 *  }
 *  
 *  - 함수와 메서드
 *      -y = f(x)
 *      -> x라는 입력값을 f에 주었을 때  y라는 출력값을 낸다.
 *      -> 메서드 : 매개변수에 입력값을 전달했을 때 본문 코드를 실행하고 변환값을 반환한다.
 */




class Human
{
    protected string name;  
    protected float height;
    protected int age;

    public Human()
    {

    }

    public string Name          //  속성
    {
        get
        {
            Debug.Log("이름에 접근했다!");
            return name;
        }
        set
        {
            Debug.Log("이름을 수정했다!");
            name = value;
        }
        
    }
    public float Height          //  속성
    {
        get 
        { 
            return height;
        }
        set
        {
            height = value;
        }

    }
    public int Age          //  속성
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }

    }

    public string GetName()
    {
        Debug.Log("이름에 접근했다!");
        return name;
    }

    public void SetName(string value)
    {
        Debug.Log("이름을 수정했다!");
        name = value;
    }

   

    public Human(string name, float height, int age)  
    {
        this.name = name;
        this.height = height;
        this.age = age;
    }

    public void Eat()
    {
        Debug.Log("eat!");
    }
    public void Eat(string something)
    {
        Debug.Log("eat!" + something);
    }

    public virtual void Walk()
    {
        Debug.Log("walk!");
    }
    public void Sleep()
    {
        Debug.Log("sleep!");
    }
}