using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100.0f;

    public float Health
    {
        get { return health; }
    }

    void TakeDamage(float value)
    {
        health -= value;
        Debug.Log("Player의 체력 : " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);    // 자기 자신을 없애라!
    }

    public float GetHelth()
    {
        return health;
    }

    void OnCollisionEnter2D(Collision2D coll)   // collider로 발생한 충돌을 감지, Collision2D -> 충돌 그 자체를 가져온다 부딪인 놈도 가져올 수 있음
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(coll.gameObject);
        }


    }
}
