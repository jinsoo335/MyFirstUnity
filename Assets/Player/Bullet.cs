using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Start()
    {
        Invoke("DestroySelf", 2.0f); // ���� �ð��� ���� �Ŀ� ���� �ǵ��� �ϴ� �޼��� (���� ��Ű�� �޼���, �ð�)
        
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }

}
