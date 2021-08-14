using UnityEngine;

public class StructExample : MonoBehaviour
{
    // 구조체 : 클래스와 매우 유사. 어떤 대상을 추상화한 데이터 구조

    /*
     *    - 구조체의 구조
     *    struct 구조채_이름{
     *    
     *    }
     */

    // * 주의!
    // 1. 구조체의 필드는 초기화 할 수 없다.
    // 2. 구조체의 생성자는 반드시 모든 필드를 초기화해야 한다.

    void Start()
    {
        Point_struct point1 = new Point_struct(1, 1);

        Debug.Log(point1.GetPoint());
    }

}

struct Point_struct     // struct는 상속은 안되지만, 인터페이스 장착은 된다.
{
    public int x;   // public int x = 1   -> 불가
    public int y;

    public Point_struct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public string GetPoint()
    {
        //return "(" + x + "," + y + ")"; 
        return $"({x}, {y})";
    }
}