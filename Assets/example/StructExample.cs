using UnityEngine;

public class StructExample : MonoBehaviour
{
    // ����ü : Ŭ������ �ſ� ����. � ����� �߻�ȭ�� ������ ����

    /*
     *    - ����ü�� ����
     *    struct ����ä_�̸�{
     *    
     *    }
     */

    // * ����!
    // 1. ����ü�� �ʵ�� �ʱ�ȭ �� �� ����.
    // 2. ����ü�� �����ڴ� �ݵ�� ��� �ʵ带 �ʱ�ȭ�ؾ� �Ѵ�.

    void Start()
    {
        Point_struct point1 = new Point_struct(1, 1);

        Debug.Log(point1.GetPoint());
    }

}

struct Point_struct     // struct�� ����� �ȵ�����, �������̽� ������ �ȴ�.
{
    public int x;   // public int x = 1   -> �Ұ�
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