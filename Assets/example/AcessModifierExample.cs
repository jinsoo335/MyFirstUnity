using UnityEngine;

public class AcessModifierExample : MonoBehaviour
{
    // ����������
    // - ĸ��ȭ���� ������ �����ϴ� ��� �� �ϳ�
    // - �ַ� ����� �տ� �پ� �����ϴ� ����

    // ������������ ����
    // 1. public : �ܺο� ����
    // 2. internal : ���� ��������� ���� ���� (����Ƽ������ �� ������Ʈ�� �����)
    // 3. protected : �Ļ�Ŭ���������� ���� ����
    // 4. private : �ܺο� �������� ����

    // ����� ��� ���������ڸ� ������ ��� ���� ������� �ʴ��� private���� �����ȴ�.
    // �� class�� ��� ���������ڸ� ������ ��� internal�� �����ȴ�.

    void Start()
    {
        Human john = new Human();
        john.Age = 1;
        john.Eat();

    }
}
