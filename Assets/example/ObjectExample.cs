using UnityEngine;

public class ObjectExample : MonoBehaviour
{
    // �ν��Ͻ�ȭ : Ŭ������ �̿��� ��ü�� ����
    // new Ŭ����_�̸�();

    void Start()
    {
        Human john = new Human();
        john.Name = "john";
        john.Age = 24;
        john.Height = 175;

        john.Eat();

    }


}
