using UnityEngine;

public class PropertyExample : MonoBehaviour
{

    // �Ӽ� : � �ʵ��� ���� �����ϰų� �����ϴ� ������ �ϴ� ���
    /*
     *  - �Ӽ��� �⺻ ����
     *  ����_������ �ڷ��� �Ӽ�_�̸�{
     *      get { return �ʵ�_�̸�; }
     *      set { �ʵ�_�̸� = value; }
     *  }
     *  
     *  - get, set => ������(accessor)
     *      - get ������ : �ش��ʵ��� ���� �����ϴ� ����
     *      - set ������ : �ش��ʵ��� ���� �����ϴ� ����
     */


    void Start()
    {
        Human chulsoo = new Human();
        chulsoo.Name = "yeonghee";
        Debug.Log(chulsoo.Name);
        chulsoo.SetName("bbobi");
        Debug.Log(chulsoo.GetName());

    }
}
