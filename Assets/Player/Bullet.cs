using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Start()
    {
        Invoke("DestroySelf", 2.0f); // 일정 시간이 지난 후에 실행 되도록 하는 메서드 (실행 시키는 메서드, 시간)
        
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }

}
