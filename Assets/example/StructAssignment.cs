using UnityEngine;

public class StructAssignment : MonoBehaviour
{
    // 참조형과 값형의 차이


    //private void Start()
    //{
    //    Point point1 = new Point(3, 3);
    //    Point point2 = point1;
    //    point2.x = 2;
    //    point2.y = 2;


    //    Debug.Log(point1.GetPoint());   //(3, 3)
    //    Debug.Log(point2.GetPoint());   //(2, 2)

    //    Point_struct point3;
    //    point3.x = 1;
    //    point3.y = 3;

    //    Point point4;
    //    // point4.x = 3; -> 불가
    //}

    
}

//class Point
//{
//    public int x;   // public int x = 1   -> 불가
//    public int y;

//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public string GetPoint()
//    {
//        //return "(" + x + "," + y + ")"; 
//        return $"({x}, {y})";
//    }
//}