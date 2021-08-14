using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    // �߻� Ŭ���� / �߻� �޼��� -> �θ�Ŭ�������� ������ �޼��带 �ڽ�Ŭ�������� �ݵ�� �������ϵ��� ������ ��
    /* �߻� �޼���� �ݵ�� �߻�Ŭ���� ���� �����ؾ� �Ѵ�.
     * 
     *  - �߻�Ŭ����
     *  abstract class Ŭ����_�̸�{
     *  
     *  }
     *  
     *  - �߻� �޼���
     *  ����_������ abstract ��ȯ_Ÿ�� �޼���_�̸�(�Ű�����);
     *  
     *  - �ڽ�Ŭ�������� ������   override �ʼ�
     *  ����_������ override ��ȯ_Ÿ�� �޼���_�̸�(�Ű�����){
     *      ... ����
     *  }
     */

    private void Start()
    {
        Bird eagle = new Bird();
        Fish gold = new Fish();

        eagle.Move();
        gold.Move();
       
    }


}

abstract class Animal
{
    public abstract void Move();
    
}

class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Fly!");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Debug.Log("Swim!");
    }
}
